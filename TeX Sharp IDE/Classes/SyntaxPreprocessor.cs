using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace TeXSharp
{
    public class SyntaxPreprocessorResult
    {
        public String Input  { get; set; }
        public String Result { get; set; }
        public String Status { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class SyntaxPreprocessor
    {
        private String inputString, outputString;
        private SyntaxPreprocessorResult result;

        public SyntaxPreprocessor()
        {

        }

        public SyntaxPreprocessorResult Transform(String _in)
        {
            this.inputString = _in;
            this.outputString = _in;
            this.result = new SyntaxPreprocessorResult();

            ReplaceAliases();
            ReplaceBlocks();
            ReplaceFunctions();

            this.result.Result = this.outputString;
            this.result.Input = this.inputString;
            this.result.Status = "Ok";

            return this.result;
        }

        private void ReplaceAliases()
        {
            this.outputString = SyntaxPreprocessorAliasesReplacer.CompleteReplaces(this.inputString);
        }

        private void ReplaceBlocks()
        {
            Regex block = new Regex("[\\w]+(\\n){1}( )*({){1}");
            Regex blockreplace = new Regex("(\\n){1}( )*({){1}");
            Regex bracket = new Regex("(\\n){1}( )*(}){1}");
            List<String> stack = new List<String>();
            int mrg = 0;
            String newblock, newbracket = "";

            List<Match> matches = new List<Match>();

            foreach (Match t in block.Matches(this.outputString))
            {
                matches.Add(t);
            }

            foreach (Match t in bracket.Matches(this.outputString))
            {
                matches.Add(t);
            }

            matches.Sort((x, y) => x.Index.CompareTo(y.Index));

            foreach (Match t in matches)
            {
                if(!t.Value.Contains("}"))
                {
                    if (this.outputString[t.Index + mrg - 1] != '\\')
                    {
                        newblock = "\\begin{" + blockreplace.Replace(t.Value, "}");

                        this.outputString = this.outputString.Substring(0, t.Index + mrg) + newblock + this.outputString.Substring(t.Index + mrg + t.Value.Length);

                        mrg += newblock.Length - t.Value.Length;

                        stack.Add("\\end{" + blockreplace.Replace(t.Value, "}"));
                    }
                }
                else
                {
                    newbracket = t.Value.Replace("}", stack[stack.Count - 1]);

                    stack.RemoveAt(stack.Count - 1);

                    this.outputString = this.outputString.Substring(0, t.Index + mrg) + newbracket + this.outputString.Substring(t.Index + mrg + t.Value.Length);

                    mrg += newbracket.Length - t.Value.Length;
                }
            }
        }

        private void ReplaceFunctions()
        {
            Regex function = new Regex("[\\w\\d]+\\([^)]*\\)");
            Regex semicolon = new Regex(";{1}");
            int mrg = 0;
            String newfunc = "";

            foreach (Match t in function.Matches(this.outputString))
            {
                newfunc = "\\" + t.Value.Replace("(", "{");

                if(newfunc.Contains(";"))
                {
                    foreach(Match s in semicolon.Matches(newfunc))
                    {
                        if(newfunc[s.Index - 1] != '\\')
                        {
                            newfunc = newfunc.Substring(0, s.Index) + "}[" + newfunc.Substring(s.Index + 1);
                            newfunc = newfunc.Replace(")", "]");
                        }
                    }
                }
                else
                {
                    newfunc = newfunc.Replace(")", "}");
                }

                newfunc = newfunc.Replace("{}", "");
                newfunc = newfunc.Replace("[]", "");

                this.outputString = this.outputString.Substring(0, t.Index + mrg) + newfunc + this.outputString.Substring(t.Index + mrg + t.Value.Length);

                mrg += newfunc.Length - t.Value.Length;
            }
        }
    }

    class SyntaxPreprocessorAliasesReplacer
    {
        static String inp_str;

        public static String CompleteReplaces(String _in)
        {
            inp_str = _in;

            Replace_use();
            Replace_document();

            return inp_str;
        }

        private static void Replace_document()
        {
            Regex document = new Regex("document\\(.*\\)(\\r)?(\\n)*({){1}");
            Regex lastbracket = new Regex(@"(}){1}");

            if(document.Matches(inp_str).Count > 0)
            {
                Match t = document.Matches(inp_str)[0];

                String tvalue = t.Value.Replace("document(", "\\documentclass{");

                String rn = "";

                if(document.Matches(inp_str)[0].Value.Contains("\r"))
                {
                    rn = "\r";
                }

                if (document.Matches(inp_str)[0].Value.Contains("\n"))
                {
                    rn += "\n";
                }

                if (tvalue.Contains(";"))
                {
                    tvalue = tvalue.Replace(";", "}[");
                    tvalue = tvalue.Replace(")" + rn + "{", "]");
                }
                else
                {
                    tvalue = tvalue.Replace(")" + rn + "{", "}");
                }
                
                inp_str = tvalue + "\n" + inp_str.Replace(t.Value, "\\begin{document}");

                if (lastbracket.Matches(inp_str).Count > 0)
                {
                    Match tt = lastbracket.Matches(inp_str)[lastbracket.Matches(inp_str).Count - 1];

                    inp_str = inp_str.Remove(tt.Index) + "\\end{document}";
                }
            }
        }

        private static void Replace_use()
        {
            Regex use = new Regex(@"use\(.*\)");

            int mrg = 0;
            String newuse = "";

            foreach (Match t in use.Matches(inp_str))
            {
                if (t.Value.Contains(";"))
                {
                    newuse = t.Value.Replace(";", "}[").Replace("use(", "\\usepackage{").Replace(")", "]");
                }
                else
                {
                    newuse = t.Value.Replace("use(", "\\usepackage{").Replace(")", "}");
                }

                inp_str = inp_str.Substring(0, t.Index + mrg) + newuse + inp_str.Substring(t.Index + mrg + t.Value.Length);
                mrg += newuse.Length - t.Value.Length;
            }
        }
    }
}
