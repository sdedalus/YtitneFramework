using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;
using Microsoft.SqlServer.TransactSql.ScriptDom;
namespace YtitneFrameworkPrototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var SqlParser = new TSql150Parser(false);
            IList<ParseError> errors = new List<ParseError>();

            var sql = SqlParser.Parse(new StringReader(""), out errors);
            typeof(TSqlScript).
        }
    }
}
