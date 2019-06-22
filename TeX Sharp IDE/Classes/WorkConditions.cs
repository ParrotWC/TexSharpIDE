using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeX_Sharp_IDE
{
    public class WorkConditions
    {
        public Boolean PreprocessorStatus, PreviewStatus;

        public Int32 CurrentWorkMode;
        public String CurrentWorkObject;

        public List<String> LoadedDocs;
        public Int32 SelectedDoc;

        public String LoadedDocument;
    }
}
