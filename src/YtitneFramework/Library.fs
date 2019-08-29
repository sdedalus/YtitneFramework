namespace YtitneFramework
open Microsoft.SqlServer.TransactSql.ScriptDom;
open System;
open System.IO;
open System.Linq;
open System.Collections.Generic;
open YtitneFramework.Strict.ActivePatterns;

module p =

    let SqlParser = new TSql150Parser(false);

    let Parse sql = 
        SqlParser.Parse(new StringReader(sql))

    let runTest =
        let response = Parse "USE AdventureWorks2012;  
        GO  
        CREATE PROCEDURE HumanResources.uspGetEmployeesTest2   
            @LastName nvarchar(50),   
            @FirstName nvarchar(50)   
        AS   
        
            SET NOCOUNT ON;  
            SELECT FirstName, LastName, Department  
            FROM HumanResources.vEmployeeDepartmentHistory  
            WHERE FirstName = @FirstName AND LastName = @LastName  
            AND EndDate IS NULL;  
        GO"
        match (fst response) with
        | TSqlScript (b) -> b |> 
            Seq.choose (function
                | TSqlBatch (x) -> Some x
                | _ -> None) |> Seq.iter (printf "%A")
        | _ -> ()
        0 
         
        



