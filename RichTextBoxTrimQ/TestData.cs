using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichTextBoxTrimQ
{
    class TestData
    {
        public TestData()
        {

        }

        public string GetDataTest1()
        {
            string dataTest = @"{\rtf1\ansi\ansicpg1251\deff0\deflang1049{\fonttbl{\f0\fnil Consolas;}{\f1\fnil\fcharset204 Consolas;}{\f2\fnil\fcharset0 Consolas;}{\f3\fnil\fcharset204 Microsoft Sans Serif;}}
{\colortbl ;\red128\green128\blue128;\red0\green128\blue0;\red0\green0\blue0;\red0\green0\blue255;}
\viewkind4\uc1\pard\cf1\f0\fs19 ///\cf2  \cf1 <summary>\cf3\par
\cf1 ///\cf2  \f1\'cc\'e5\'f2\'ee\'e4\f0  \f1\'e8\'f1\'f2\'ee\'f7\'ed\'e8\'ea\f0  \f1\'e4\'eb\'ff\f0  \f1\'e3\'e5\'ed\'e5\'f0\'e0\'f6\'e8\'e8\f0  Rtf. \cf3\par
\cf1 ///\cf2  \f1\'cf\'ee\'eb\'fc\'e7\'ee\'e2\'e0\'f2\'e5\'eb\'fc\f0  \f1\'e4\'ee\'eb\'e6\'e5\'ed\f0  \f1\'e2\'f1\'f2\'e0\'e2\'e8\'f2\'fc\f0  \f1\'e5\'e3\'ee\f0  \f1\'e2\f0  RichTextBox\cf3\par
\cf1 ///\cf2  \cf1 </summary>\cf3\par
\cf4 public\cf3  \cf4 void\cf3  GetDataTest1()\par
\{\par
   List<\cf4 string\cf3 > ls = \cf4 new\cf3  List<\cf4 string\cf3 >();\par
            \par
   \cf2 // \f1\'ca\'ee\'ec\'ec\'e5\'ed\'f2\'e0\'f0\'e8\'e9\cf3\f0\par
   \cf4 foreach\cf3  (var item \cf4 in\cf3  ls)\par
   \{\par
\par
   \}\par
\par
\f2  \f1   \cf4\f0 int\cf3  i = 0;\par
\f2  \f1   \cf4\f0 bool\cf3  flaf = \cf4 true\cf3 ;\par
   \cf4 if\cf3  (flaf = \cf4 true\cf3 )\par
   \{\par
\par
   \}\par
\}\cf0\f3\fs17\par
}";

            return dataTest;
        }



    }
}
