// This is auto-generated source code, DO NOT EDIT!

namespace YtitneFramework.Strict

[<AutoOpen>]
module ActivePatterns =

  let (|TSqlFragment|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment as node ->
      Some (node.StartOffset, node.FragmentLength, node.StartLine, node.StartColumn, node.FirstTokenIndex, node.LastTokenIndex, node.ScriptTokenStream |> Seq.toList)
    | _ -> None

  let (|MultiPartIdentifier|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.MultiPartIdentifier as node ->
      Some (node.Count, node.Identifiers |> Seq.toList)
    | _ -> None

  let (|SchemaObjectName|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.SchemaObjectName as node ->
      Some (node.ServerIdentifier, node.DatabaseIdentifier, node.SchemaIdentifier, node.BaseIdentifier)
    | _ -> None

  let (|ChildObjectName|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ChildObjectName as node ->
      Some (node.BaseIdentifier, node.DatabaseIdentifier, node.SchemaIdentifier, node.ServerIdentifier, node.ChildIdentifier)
    | _ -> None

  let (|Identifier|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.Identifier as node ->
      Some (node.Value, node.QuoteType)
    | _ -> None

  let (|PrimaryExpr|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.PrimaryExpression as node ->
      Some (node.Collation)
    | _ -> None

  let (|Literal|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.Literal as node ->
      Some (node.LiteralType, node.Value)
    | _ -> None

  let (|IdentifierLiteral|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.IdentifierLiteral as node ->
      Some (node.LiteralType, node.QuoteType)
    | _ -> None

  let (|IdentifierOrValueExpr|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.IdentifierOrValueExpression as node ->
      Some (node.Value, node.Identifier, node.ValueExpression)
    | _ -> None

  let (|IntegerLiteral|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.IntegerLiteral as node ->
      Some (node.LiteralType)
    | _ -> None

  let (|NumericLiteral|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.NumericLiteral as node ->
      Some (node.LiteralType)
    | _ -> None

  let (|RealLiteral|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.RealLiteral as node ->
      Some (node.LiteralType)
    | _ -> None

  let (|MoneyLiteral|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.MoneyLiteral as node ->
      Some (node.LiteralType)
    | _ -> None

  let (|BinaryLiteral|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.BinaryLiteral as node ->
      Some (node.LiteralType, node.IsLargeObject)
    | _ -> None

  let (|StringLiteral|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.StringLiteral as node ->
      Some (node.LiteralType, node.IsNational, node.IsLargeObject)
    | _ -> None

  let (|NullLiteral|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.NullLiteral as node ->
      Some (node.LiteralType)
    | _ -> None

  let (|DefaultLiteral|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.DefaultLiteral as node ->
      Some (node.LiteralType)
    | _ -> None

  let (|MaxLiteral|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.MaxLiteral as node ->
      Some (node.LiteralType)
    | _ -> None

  let (|OdbcLiteral|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.OdbcLiteral as node ->
      Some (node.LiteralType, node.OdbcLiteralType, node.IsNational)
    | _ -> None

  let (|StatementList|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.StatementList as node ->
      Some (node.Statements |> Seq.toList)
    | _ -> None

  let (|Execute|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ExecuteStatement as node ->
      Some (node.ExecuteSpecification, node.Options |> Seq.toList)
    | _ -> None

  let (|ExecuteOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ExecuteOption as node ->
      Some (node.OptionKind)
    | _ -> None

  let (|ResultSetsExecuteOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ResultSetsExecuteOption as node ->
      Some (node.ResultSetsOptionKind, node.Definitions |> Seq.toList)
    | _ -> None

  let (|ResultSetDef|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ResultSetDefinition as node ->
      Some (node.ResultSetType)
    | _ -> None

  let (|InlineResultSetDef|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.InlineResultSetDefinition as node ->
      Some (node.ResultColumnDefinitions |> Seq.toList)
    | _ -> None

  let (|ResultColumnDef|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ResultColumnDefinition as node ->
      Some (node.ColumnDefinition, node.Nullable)
    | _ -> None

  let (|SchemaObjectResultSetDef|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.SchemaObjectResultSetDefinition as node ->
      Some (node.Name)
    | _ -> None

  let (|ExecuteSpecification|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ExecuteSpecification as node ->
      Some (node.Variable, node.LinkedServer, node.ExecuteContext, node.ExecutableEntity)
    | _ -> None

  let (|ExecuteContext|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ExecuteContext as node ->
      Some (node.Principal, node.Kind)
    | _ -> None

  let (|ExecuteParameter|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ExecuteParameter as node ->
      Some (node.Variable, node.ParameterValue, node.IsOutput)
    | _ -> None

  let (|ExecutableEntity|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ExecutableEntity as node ->
      Some (node.Parameters |> Seq.toList)
    | _ -> None

  let (|ProcedureReferenceName|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ProcedureReferenceName as node ->
      Some (node.ProcedureReference, node.ProcedureVariable)
    | _ -> None

  let (|ExecutableProcedureRef|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ExecutableProcedureReference as node ->
      Some (node.ProcedureReference, node.AdHocDataSource)
    | _ -> None

  let (|ExecutableStringList|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ExecutableStringList as node ->
      Some (node.Strings |> Seq.toList)
    | _ -> None

  let (|AdHocDataSource|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AdHocDataSource as node ->
      Some (node.ProviderName, node.InitString)
    | _ -> None

  let (|ViewOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ViewOption as node ->
      Some (node.OptionKind)
    | _ -> None

  let (|ViewStatementBody|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ViewStatementBody as node ->
      Some (node.SchemaObjectName, node.Columns |> Seq.toList, node.ViewOptions |> Seq.toList, node.SelectStatement, node.WithCheckOption)
    | _ -> None

  let (|TriggerObject|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.TriggerObject as node ->
      Some (node.Name, node.TriggerScope)
    | _ -> None

  let (|TriggerOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.TriggerOption as node ->
      Some (node.OptionKind)
    | _ -> None

  let (|ExecuteAsTriggerOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ExecuteAsTriggerOption as node ->
      Some (node.ExecuteAsClause)
    | _ -> None

  let (|TriggerAction|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.TriggerAction as node ->
      Some (node.TriggerActionType, node.EventTypeGroup)
    | _ -> None

  let (|TriggerStatementBody|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.TriggerStatementBody as node ->
      Some (node.Name, node.TriggerObject, node.Options |> Seq.toList, node.TriggerType, node.TriggerActions |> Seq.toList, node.WithAppend, node.IsNotForReplication, node.StatementList, node.MethodSpecifier)
    | _ -> None

  let (|ProcedureStatementBodyBase|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ProcedureStatementBodyBase as node ->
      Some (node.Parameters |> Seq.toList, node.StatementList, node.MethodSpecifier)
    | _ -> None

  let (|ProcedureStatementBody|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ProcedureStatementBody as node ->
      Some (node.ProcedureReference, node.IsForReplication, node.Options |> Seq.toList)
    | _ -> None

  let (|ProcedureRef|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ProcedureReference as node ->
      Some (node.Name, node.Number)
    | _ -> None

  let (|MethodSpecifier|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.MethodSpecifier as node ->
      Some (node.AssemblyName, node.ClassName, node.MethodName)
    | _ -> None

  let (|FunctionStatementBody|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.FunctionStatementBody as node ->
      Some (node.Name, node.ReturnType, node.Options |> Seq.toList, node.OrderHint)
    | _ -> None

  let (|ProcedureOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ProcedureOption as node ->
      Some (node.OptionKind)
    | _ -> None

  let (|ExecuteAsProcedureOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ExecuteAsProcedureOption as node ->
      Some (node.ExecuteAs)
    | _ -> None

  let (|FunctionOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.FunctionOption as node ->
      Some (node.OptionKind)
    | _ -> None

  let (|InlineFunctionOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.InlineFunctionOption as node ->
      Some (node.OptionState)
    | _ -> None

  let (|ExecuteAsFunctionOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ExecuteAsFunctionOption as node ->
      Some (node.ExecuteAs)
    | _ -> None

  let (|XmlNamespaces|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.XmlNamespaces as node ->
      Some (node.XmlNamespacesElements |> Seq.toList)
    | _ -> None

  let (|XmlNamespacesElement|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.XmlNamespacesElement as node ->
      Some (node.String)
    | _ -> None

  let (|XmlNamespacesAliasElement|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.XmlNamespacesAliasElement as node ->
      Some (node.Identifier)
    | _ -> None

  let (|CommonTableExpr|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.CommonTableExpression as node ->
      Some (node.ExpressionName, node.Columns |> Seq.toList, node.QueryExpression)
    | _ -> None

  let (|WithCtesAndXmlNamespaces|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.WithCtesAndXmlNamespaces as node ->
      Some (node.XmlNamespaces, node.CommonTableExpressions |> Seq.toList, node.ChangeTrackingContext)
    | _ -> None

  let (|TableValuedFunctionReturnType|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.TableValuedFunctionReturnType as node ->
      Some (node.DeclareTableVariableBody)
    | _ -> None

  let (|DataTypeRef|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.DataTypeReference as node ->
      Some (node.Name)
    | _ -> None

  let (|ParameterizedDataTypeRef|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ParameterizedDataTypeReference as node ->
      Some (node.Parameters |> Seq.toList)
    | _ -> None

  let (|SqlDataTypeRef|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.SqlDataTypeReference as node ->
      Some (node.SqlDataTypeOption)
    | _ -> None

  let (|XmlDataTypeRef|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.XmlDataTypeReference as node ->
      Some (node.XmlDataTypeOption, node.XmlSchemaCollection)
    | _ -> None

  let (|ScalarFunctionReturnType|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ScalarFunctionReturnType as node ->
      Some (node.DataType)
    | _ -> None

  let (|SelectFunctionReturnType|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.SelectFunctionReturnType as node ->
      Some (node.SelectStatement)
    | _ -> None

  let (|TableDef|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.TableDefinition as node ->
      Some (node.ColumnDefinitions |> Seq.toList, node.TableConstraints |> Seq.toList, node.Indexes |> Seq.toList, node.SystemTimePeriod)
    | _ -> None

  let (|DeclareTableVariableBody|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.DeclareTableVariableBody as node ->
      Some (node.VariableName, node.AsDefined, node.Definition)
    | _ -> None

  let (|DeclareTableVariable|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.DeclareTableVariableStatement as node ->
      Some (node.Body)
    | _ -> None

  let (|TableReferenceWithAlias|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.TableReferenceWithAlias as node ->
      Some (node.Alias)
    | _ -> None

  let (|NamedTableRef|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.NamedTableReference as node ->
      Some (node.SchemaObject, node.TableHints |> Seq.toList, node.TableSampleClause, node.TemporalClause)
    | _ -> None

  let (|TableReferenceWithAliasAndColumns|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.TableReferenceWithAliasAndColumns as node ->
      Some (node.Columns |> Seq.toList)
    | _ -> None

  let (|SchemaObjectFunctionTableRef|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.SchemaObjectFunctionTableReference as node ->
      Some (node.SchemaObject, node.Parameters |> Seq.toList)
    | _ -> None

  let (|TableHint|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.TableHint as node ->
      Some (node.HintKind)
    | _ -> None

  let (|IndexTableHint|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.IndexTableHint as node ->
      Some (node.IndexValues |> Seq.toList)
    | _ -> None

  let (|LiteralTableHint|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.LiteralTableHint as node ->
      Some (node.Value)
    | _ -> None

  let (|QueryDerivedTable|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.QueryDerivedTable as node ->
      Some (node.QueryExpression)
    | _ -> None

  let (|InlineDerivedTable|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.InlineDerivedTable as node ->
      Some (node.RowValues |> Seq.toList)
    | _ -> None

  let (|SubqueryComparisonPredicate|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.SubqueryComparisonPredicate as node ->
      Some (node.Expression, node.ComparisonType, node.Subquery, node.SubqueryComparisonPredicateType)
    | _ -> None

  let (|ExistsPredicate|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ExistsPredicate as node ->
      Some (node.Subquery)
    | _ -> None

  let (|LikePredicate|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.LikePredicate as node ->
      Some (node.FirstExpression, node.SecondExpression, node.NotDefined, node.OdbcEscape, node.EscapeExpression)
    | _ -> None

  let (|InPredicate|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.InPredicate as node ->
      Some (node.Expression, node.Subquery, node.NotDefined, node.Values |> Seq.toList)
    | _ -> None

  let (|FullTextPredicate|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.FullTextPredicate as node ->
      Some (node.FullTextFunctionType, node.Columns |> Seq.toList, node.Value, node.LanguageTerm, node.PropertyName)
    | _ -> None

  let (|UserDefinedTypePropertyAccess|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.UserDefinedTypePropertyAccess as node ->
      Some (node.CallTarget, node.PropertyName)
    | _ -> None

  let (|StatementWithCtesAndXmlNamespaces|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.StatementWithCtesAndXmlNamespaces as node ->
      Some (node.WithCtesAndXmlNamespaces, node.OptimizerHints |> Seq.toList)
    | _ -> None

  let (|Select|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.SelectStatement as node ->
      Some (node.QueryExpression, node.Into, node.On, node.ComputeClauses |> Seq.toList)
    | _ -> None

  let (|XmlForClause|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.XmlForClause as node ->
      Some (node.Options |> Seq.toList)
    | _ -> None

  let (|XmlForClauseOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.XmlForClauseOption as node ->
      Some (node.OptionKind, node.Value)
    | _ -> None

  let (|JsonForClause|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.JsonForClause as node ->
      Some (node.Options |> Seq.toList)
    | _ -> None

  let (|JsonForClauseOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.JsonForClauseOption as node ->
      Some (node.OptionKind, node.Value)
    | _ -> None

  let (|UpdateForClause|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.UpdateForClause as node ->
      Some (node.Columns |> Seq.toList)
    | _ -> None

  let (|OptimizerHint|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.OptimizerHint as node ->
      Some (node.HintKind)
    | _ -> None

  let (|LiteralOptimizerHint|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.LiteralOptimizerHint as node ->
      Some (node.Value)
    | _ -> None

  let (|TableHintsOptimizerHint|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.TableHintsOptimizerHint as node ->
      Some (node.ObjectName, node.TableHints |> Seq.toList)
    | _ -> None

  let (|ForceSeekTableHint|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ForceSeekTableHint as node ->
      Some (node.IndexValue, node.ColumnValues |> Seq.toList)
    | _ -> None

  let (|OptimizeForOptimizerHint|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.OptimizeForOptimizerHint as node ->
      Some (node.Pairs |> Seq.toList, node.IsForUnknown)
    | _ -> None

  let (|UseHintList|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.UseHintList as node ->
      Some (node.Hints |> Seq.toList)
    | _ -> None

  let (|VariableValuePair|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.VariableValuePair as node ->
      Some (node.Variable, node.Value, node.IsForUnknown)
    | _ -> None

  let (|WhenClause|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.WhenClause as node ->
      Some (node.ThenExpression)
    | _ -> None

  let (|SimpleWhenClause|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.SimpleWhenClause as node ->
      Some (node.WhenExpression)
    | _ -> None

  let (|SearchedWhenClause|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.SearchedWhenClause as node ->
      Some (node.WhenExpression)
    | _ -> None

  let (|CaseExpr|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.CaseExpression as node ->
      Some (node.ElseExpression)
    | _ -> None

  let (|SimpleCaseExpr|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.SimpleCaseExpression as node ->
      Some (node.InputExpression, node.WhenClauses |> Seq.toList)
    | _ -> None

  let (|SearchedCaseExpr|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.SearchedCaseExpression as node ->
      Some (node.WhenClauses |> Seq.toList)
    | _ -> None

  let (|NullIfExpr|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.NullIfExpression as node ->
      Some (node.FirstExpression, node.SecondExpression)
    | _ -> None

  let (|CoalesceExpr|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.CoalesceExpression as node ->
      Some (node.Expressions |> Seq.toList)
    | _ -> None

  let (|IIfCall|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.IIfCall as node ->
      Some (node.Predicate, node.ThenExpression, node.ElseExpression)
    | _ -> None

  let (|FullTextTableRef|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.FullTextTableReference as node ->
      Some (node.FullTextFunctionType, node.TableName, node.Columns |> Seq.toList, node.SearchCondition, node.TopN, node.Language, node.PropertyName)
    | _ -> None

  let (|SemanticTableRef|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.SemanticTableReference as node ->
      Some (node.SemanticFunctionType, node.TableName, node.Columns |> Seq.toList, node.SourceKey, node.MatchedColumn, node.MatchedKey)
    | _ -> None

  let (|OpenXmlTableRef|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.OpenXmlTableReference as node ->
      Some (node.Variable, node.RowPattern, node.Flags, node.SchemaDeclarationItems |> Seq.toList, node.TableName)
    | _ -> None

  let (|OpenJsonTableRef|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.OpenJsonTableReference as node ->
      Some (node.Variable, node.RowPattern, node.SchemaDeclarationItems |> Seq.toList)
    | _ -> None

  let (|OpenRowsetTableRef|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.OpenRowsetTableReference as node ->
      Some (node.ProviderName, node.DataSource, node.UserId, node.Password, node.ProviderString, node.Query, node.Object)
    | _ -> None

  let (|InternalOpenRowset|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.InternalOpenRowset as node ->
      Some (node.Identifier, node.VarArgs |> Seq.toList)
    | _ -> None

  let (|BulkOpenRowset|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.BulkOpenRowset as node ->
      Some (node.DataFile, node.Options |> Seq.toList)
    | _ -> None

  let (|OpenQueryTableRef|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.OpenQueryTableReference as node ->
      Some (node.LinkedServer, node.Query)
    | _ -> None

  let (|AdHocTableRef|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AdHocTableReference as node ->
      Some (node.DataSource, node.Object)
    | _ -> None

  let (|SchemaDeclarationItem|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.SchemaDeclarationItem as node ->
      Some (node.ColumnDefinition, node.Mapping)
    | _ -> None

  let (|SchemaDeclarationItemOpenjson|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.SchemaDeclarationItemOpenjson as node ->
      Some (node.AsJson)
    | _ -> None

  let (|ConvertCall|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ConvertCall as node ->
      Some (node.DataType, node.Parameter, node.Style)
    | _ -> None

  let (|TryConvertCall|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.TryConvertCall as node ->
      Some (node.DataType, node.Parameter, node.Style)
    | _ -> None

  let (|ParseCall|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ParseCall as node ->
      Some (node.StringValue, node.DataType, node.Culture)
    | _ -> None

  let (|TryParseCall|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.TryParseCall as node ->
      Some (node.StringValue, node.DataType, node.Culture)
    | _ -> None

  let (|CastCall|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.CastCall as node ->
      Some (node.DataType, node.Parameter)
    | _ -> None

  let (|TryCastCall|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.TryCastCall as node ->
      Some (node.DataType, node.Parameter)
    | _ -> None

  let (|AtTimeZoneCall|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AtTimeZoneCall as node ->
      Some (node.DateValue, node.TimeZone)
    | _ -> None

  let (|FunctionCall|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.FunctionCall as node ->
      Some (node.CallTarget, node.FunctionName, node.Parameters |> Seq.toList, node.UniqueRowFilter, node.OverClause, node.WithinGroupClause)
    | _ -> None

  let (|ExpressionCallTarget|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ExpressionCallTarget as node ->
      Some (node.Expression)
    | _ -> None

  let (|MultiPartIdentifierCallTarget|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.MultiPartIdentifierCallTarget as node ->
      Some (node.MultiPartIdentifier)
    | _ -> None

  let (|UserDefinedTypeCallTarget|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.UserDefinedTypeCallTarget as node ->
      Some (node.SchemaObjectName)
    | _ -> None

  let (|LeftFunctionCall|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.LeftFunctionCall as node ->
      Some (node.Parameters |> Seq.toList)
    | _ -> None

  let (|RightFunctionCall|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.RightFunctionCall as node ->
      Some (node.Parameters |> Seq.toList)
    | _ -> None

  let (|PartitionFunctionCall|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.PartitionFunctionCall as node ->
      Some (node.DatabaseName, node.FunctionName, node.Parameters |> Seq.toList)
    | _ -> None

  let (|OverClause|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.OverClause as node ->
      Some (node.Partitions |> Seq.toList, node.OrderByClause, node.WindowFrameClause)
    | _ -> None

  let (|ParameterlessCall|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ParameterlessCall as node ->
      Some (node.ParameterlessCallType)
    | _ -> None

  let (|ScalarSubquery|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ScalarSubquery as node ->
      Some (node.QueryExpression)
    | _ -> None

  let (|OdbcFunctionCall|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.OdbcFunctionCall as node ->
      Some (node.Name, node.ParametersUsed, node.Parameters |> Seq.toList)
    | _ -> None

  let (|ExtractFromExpr|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ExtractFromExpression as node ->
      Some (node.Expression, node.ExtractedElement)
    | _ -> None

  let (|OdbcConvertSpecification|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.OdbcConvertSpecification as node ->
      Some (node.Identifier)
    | _ -> None

  let (|BeginEndBlock|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.BeginEndBlockStatement as node ->
      Some (node.StatementList)
    | _ -> None

  let (|BeginEndAtomicBlock|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.BeginEndAtomicBlockStatement as node ->
      Some (node.Options |> Seq.toList)
    | _ -> None

  let (|AtomicBlockOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AtomicBlockOption as node ->
      Some (node.OptionKind)
    | _ -> None

  let (|LiteralAtomicBlockOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.LiteralAtomicBlockOption as node ->
      Some (node.Value)
    | _ -> None

  let (|IdentifierAtomicBlockOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.IdentifierAtomicBlockOption as node ->
      Some (node.Value)
    | _ -> None

  let (|OnOffAtomicBlockOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.OnOffAtomicBlockOption as node ->
      Some (node.OptionState)
    | _ -> None

  let (|Transaction|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.TransactionStatement as node ->
      Some (node.Name)
    | _ -> None

  let (|BeginTransaction|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.BeginTransactionStatement as node ->
      Some (node.Distributed, node.MarkDefined, node.MarkDescription)
    | _ -> None

  let (|ColumnWithSortOrder|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ColumnWithSortOrder as node ->
      Some (node.Column, node.SortOrder)
    | _ -> None

  let (|CommitTransaction|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.CommitTransactionStatement as node ->
      Some (node.DelayedDurabilityOption)
    | _ -> None

  let (|CreateDefault|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.CreateDefaultStatement as node ->
      Some (node.Name, node.Expression)
    | _ -> None

  let (|CreateRule|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.CreateRuleStatement as node ->
      Some (node.Name, node.Expression)
    | _ -> None

  let (|DeclareVariableElement|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.DeclareVariableElement as node ->
      Some (node.VariableName, node.DataType, node.Nullable, node.Value)
    | _ -> None

  let (|DeclareVariable|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.DeclareVariableStatement as node ->
      Some (node.Declarations |> Seq.toList)
    | _ -> None

  let (|GoTo|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.GoToStatement as node ->
      Some (node.LabelName)
    | _ -> None

  let (|If|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.IfStatement as node ->
      Some (node.Predicate, node.ThenStatement, node.ElseStatement)
    | _ -> None

  let (|Label|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.LabelStatement as node ->
      Some (node.Value)
    | _ -> None

  let (|ProcedureParameter|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ProcedureParameter as node ->
      Some (node.IsVarying, node.Modifier)
    | _ -> None

  let (|While|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.WhileStatement as node ->
      Some (node.Predicate, node.Statement)
    | _ -> None

  let (|Delete|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.DeleteStatement as node ->
      Some (node.DeleteSpecification)
    | _ -> None

  let (|DataModificationSpecification|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.DataModificationSpecification as node ->
      Some (node.Target, node.TopRowFilter, node.OutputIntoClause, node.OutputClause)
    | _ -> None

  let (|UpdateDeleteSpecificationBase|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.UpdateDeleteSpecificationBase as node ->
      Some (node.FromClause, node.WhereClause)
    | _ -> None

  let (|Insert|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.InsertStatement as node ->
      Some (node.InsertSpecification)
    | _ -> None

  let (|InsertSpecification|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.InsertSpecification as node ->
      Some (node.InsertOption, node.InsertSource, node.Columns |> Seq.toList)
    | _ -> None

  let (|Update|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.UpdateStatement as node ->
      Some (node.UpdateSpecification)
    | _ -> None

  let (|UpdateSpecification|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.UpdateSpecification as node ->
      Some (node.SetClauses |> Seq.toList)
    | _ -> None

  let (|CreateSchema|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.CreateSchemaStatement as node ->
      Some (node.Name, node.StatementList, node.Owner)
    | _ -> None

  let (|WaitFor|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.WaitForStatement as node ->
      Some (node.WaitForOption, node.Parameter, node.Timeout, node.Statement)
    | _ -> None

  let (|ReadText|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ReadTextStatement as node ->
      Some (node.Column, node.TextPointer, node.Offset, node.Size, node.HoldLock)
    | _ -> None

  let (|TextModification|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.TextModificationStatement as node ->
      Some (node.Bulk, node.Column, node.TextId, node.Timestamp, node.WithLog)
    | _ -> None

  let (|UpdateText|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.UpdateTextStatement as node ->
      Some (node.InsertOffset, node.DeleteLength, node.SourceColumn, node.SourceParameter)
    | _ -> None

  let (|WriteText|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.WriteTextStatement as node ->
      Some (node.SourceParameter)
    | _ -> None

  let (|LineNo|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.LineNoStatement as node ->
      Some (node.LineNo)
    | _ -> None

  let (|Security|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.SecurityStatement as node ->
      Some (node.Permissions |> Seq.toList, node.SecurityTargetObject, node.Principals |> Seq.toList, node.AsClause)
    | _ -> None

  let (|Grant|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.GrantStatement as node ->
      Some (node.WithGrantOption)
    | _ -> None

  let (|Deny|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.DenyStatement as node ->
      Some (node.CascadeOption)
    | _ -> None

  let (|Revoke|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.RevokeStatement as node ->
      Some (node.GrantOptionFor, node.CascadeOption)
    | _ -> None

  let (|AlterAuthorization|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlterAuthorizationStatement as node ->
      Some (node.SecurityTargetObject, node.ToSchemaOwner, node.PrincipalName)
    | _ -> None

  let (|Permission|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.Permission as node ->
      Some (node.Identifiers |> Seq.toList, node.Columns |> Seq.toList)
    | _ -> None

  let (|SecurityTargetObject|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.SecurityTargetObject as node ->
      Some (node.ObjectKind, node.ObjectName, node.Columns |> Seq.toList)
    | _ -> None

  let (|SecurityTargetObjectName|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.SecurityTargetObjectName as node ->
      Some (node.MultiPartIdentifier)
    | _ -> None

  let (|SecurityPrincipal|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.SecurityPrincipal as node ->
      Some (node.PrincipalType, node.Identifier)
    | _ -> None

  let (|SecurityStatementBody80|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.SecurityStatementBody80 as node ->
      Some (node.SecurityElement80, node.SecurityUserClause80)
    | _ -> None

  let (|GrantStatement80|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.GrantStatement80 as node ->
      Some (node.WithGrantOption, node.AsClause)
    | _ -> None

  let (|DenyStatement80|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.DenyStatement80 as node ->
      Some (node.CascadeOption)
    | _ -> None

  let (|RevokeStatement80|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.RevokeStatement80 as node ->
      Some (node.GrantOptionFor, node.CascadeOption, node.AsClause)
    | _ -> None

  let (|CommandSecurityElement80|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.CommandSecurityElement80 as node ->
      Some (node.All, node.CommandOptions)
    | _ -> None

  let (|PrivilegeSecurityElement80|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.PrivilegeSecurityElement80 as node ->
      Some (node.Privileges |> Seq.toList, node.SchemaObjectName, node.Columns |> Seq.toList)
    | _ -> None

  let (|Privilege80|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.Privilege80 as node ->
      Some (node.Columns |> Seq.toList, node.PrivilegeType80)
    | _ -> None

  let (|SecurityUserClause80|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.SecurityUserClause80 as node ->
      Some (node.Users |> Seq.toList, node.UserType80)
    | _ -> None

  let (|AssignmentSetClause|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AssignmentSetClause as node ->
      Some (node.Variable, node.Column, node.NewValue, node.AssignmentKind)
    | _ -> None

  let (|FunctionCallSetClause|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.FunctionCallSetClause as node ->
      Some (node.MutatorFunction)
    | _ -> None

  let (|ValuesInsertSource|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ValuesInsertSource as node ->
      Some (node.IsDefaultValues, node.RowValues |> Seq.toList)
    | _ -> None

  let (|SelectInsertSource|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.SelectInsertSource as node ->
      Some (node.Select)
    | _ -> None

  let (|ExecuteInsertSource|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ExecuteInsertSource as node ->
      Some (node.Execute)
    | _ -> None

  let (|RowValue|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.RowValue as node ->
      Some (node.ColumnValues |> Seq.toList)
    | _ -> None

  let (|Print|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.PrintStatement as node ->
      Some (node.Expression)
    | _ -> None

  let (|UpdateCall|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.UpdateCall as node ->
      Some (node.Identifier)
    | _ -> None

  let (|TSEqualCall|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.TSEqualCall as node ->
      Some (node.FirstExpression, node.SecondExpression)
    | _ -> None

  let (|LiteralRange|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.LiteralRange as node ->
      Some (node.From, node.To)
    | _ -> None

  let (|VariableRef|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.VariableReference as node ->
      Some (node.Name)
    | _ -> None

  let (|OnOffOptionValue|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.OnOffOptionValue as node ->
      Some (node.OptionState)
    | _ -> None

  let (|LiteralOptionValue|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.LiteralOptionValue as node ->
      Some (node.Value)
    | _ -> None

  let (|GlobalVariableExpr|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.GlobalVariableExpression as node ->
      Some (node.Name)
    | _ -> None

  let (|IdentifierOrScalarExpr|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.IdentifierOrScalarExpression as node ->
      Some (node.Identifier, node.ScalarExpression)
    | _ -> None

  let (|SchemaObjectNameOrValueExpr|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.SchemaObjectNameOrValueExpression as node ->
      Some (node.SchemaObjectName, node.ValueExpression)
    | _ -> None

  let (|ParenthesisExpr|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ParenthesisExpression as node ->
      Some (node.Expression)
    | _ -> None

  let (|ColumnReferenceExpr|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ColumnReferenceExpression as node ->
      Some (node.ColumnType, node.MultiPartIdentifier)
    | _ -> None

  let (|NextValueForExpr|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.NextValueForExpression as node ->
      Some (node.SequenceName, node.OverClause)
    | _ -> None

  let (|Sequence|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.SequenceStatement as node ->
      Some (node.Name, node.SequenceOptions |> Seq.toList)
    | _ -> None

  let (|SequenceOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.SequenceOption as node ->
      Some (node.OptionKind, node.NoValue)
    | _ -> None

  let (|DataTypeSequenceOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.DataTypeSequenceOption as node ->
      Some (node.DataType)
    | _ -> None

  let (|ScalarExpressionSequenceOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ScalarExpressionSequenceOption as node ->
      Some (node.OptionValue)
    | _ -> None

  let (|DropObjects|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.DropObjectsStatement as node ->
      Some (node.Objects |> Seq.toList, node.IsIfExists)
    | _ -> None

  let (|SecurityPolicy|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.SecurityPolicyStatement as node ->
      Some (node.Name, node.NotForReplication, node.SecurityPolicyOptions |> Seq.toList, node.SecurityPredicateActions |> Seq.toList, node.ActionType)
    | _ -> None

  let (|SecurityPredicateAction|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.SecurityPredicateAction as node ->
      Some (node.ActionType, node.SecurityPredicateType, node.FunctionCall, node.TargetObjectName, node.SecurityPredicateOperation)
    | _ -> None

  let (|SecurityPolicyOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.SecurityPolicyOption as node ->
      Some (node.OptionKind, node.OptionState)
    | _ -> None

  let (|CreateColumnMasterKey|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.CreateColumnMasterKeyStatement as node ->
      Some (node.Name, node.Parameters |> Seq.toList)
    | _ -> None

  let (|ColumnMasterKeyParameter|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ColumnMasterKeyParameter as node ->
      Some (node.ParameterKind)
    | _ -> None

  let (|ColumnMasterKeyStoreProviderNameParameter|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ColumnMasterKeyStoreProviderNameParameter as node ->
      Some (node.Name)
    | _ -> None

  let (|ColumnMasterKeyPathParameter|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ColumnMasterKeyPathParameter as node ->
      Some (node.Path)
    | _ -> None

  let (|DropUnownedObject|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.DropUnownedObjectStatement as node ->
      Some (node.Name, node.IsIfExists)
    | _ -> None

  let (|ColumnEncryptionKey|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ColumnEncryptionKeyStatement as node ->
      Some (node.Name, node.ColumnEncryptionKeyValues |> Seq.toList)
    | _ -> None

  let (|AlterColumnEncryptionKey|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlterColumnEncryptionKeyStatement as node ->
      Some (node.AlterType)
    | _ -> None

  let (|ColumnEncryptionKeyValue|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ColumnEncryptionKeyValue as node ->
      Some (node.Parameters |> Seq.toList)
    | _ -> None

  let (|ColumnEncryptionKeyValueParameter|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ColumnEncryptionKeyValueParameter as node ->
      Some (node.ParameterKind)
    | _ -> None

  let (|ColumnMasterKeyNameParameter|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ColumnMasterKeyNameParameter as node ->
      Some (node.Name)
    | _ -> None

  let (|ColumnEncryptionAlgorithmNameParameter|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ColumnEncryptionAlgorithmNameParameter as node ->
      Some (node.Algorithm)
    | _ -> None

  let (|EncryptedValueParameter|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.EncryptedValueParameter as node ->
      Some (node.Value)
    | _ -> None

  let (|ExternalTable|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ExternalTableStatement as node ->
      Some (node.SchemaObjectName, node.ColumnDefinitions |> Seq.toList, node.DataSource, node.ExternalTableOptions |> Seq.toList)
    | _ -> None

  let (|ExternalTableOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ExternalTableOption as node ->
      Some (node.OptionKind)
    | _ -> None

  let (|ExternalTableLiteralOrIdentifierOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ExternalTableLiteralOrIdentifierOption as node ->
      Some (node.Value)
    | _ -> None

  let (|ExternalTableDistributionOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ExternalTableDistributionOption as node ->
      Some (node.Value)
    | _ -> None

  let (|ExternalTableRejectTypeOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ExternalTableRejectTypeOption as node ->
      Some (node.Value)
    | _ -> None

  let (|ExternalTableShardedDistributionPolicy|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ExternalTableShardedDistributionPolicy as node ->
      Some (node.ShardingColumn)
    | _ -> None

  let (|ExternalDataSource|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ExternalDataSourceStatement as node ->
      Some (node.Name, node.DataSourceType, node.Location, node.ExternalDataSourceOptions |> Seq.toList)
    | _ -> None

  let (|ExternalDataSourceOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ExternalDataSourceOption as node ->
      Some (node.OptionKind)
    | _ -> None

  let (|ExternalDataSourceLiteralOrIdentifierOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ExternalDataSourceLiteralOrIdentifierOption as node ->
      Some (node.Value)
    | _ -> None

  let (|ExternalFileFormat|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ExternalFileFormatStatement as node ->
      Some (node.Name, node.FormatType, node.ExternalFileFormatOptions |> Seq.toList)
    | _ -> None

  let (|ExternalFileFormatOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ExternalFileFormatOption as node ->
      Some (node.OptionKind)
    | _ -> None

  let (|ExternalFileFormatLiteralOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ExternalFileFormatLiteralOption as node ->
      Some (node.Value)
    | _ -> None

  let (|ExternalFileFormatUseDefaultTypeOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ExternalFileFormatUseDefaultTypeOption as node ->
      Some (node.ExternalFileFormatUseDefaultType)
    | _ -> None

  let (|ExternalFileFormatContainerOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ExternalFileFormatContainerOption as node ->
      Some (node.Suboptions |> Seq.toList)
    | _ -> None

  let (|Assembly|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AssemblyStatement as node ->
      Some (node.Name, node.Parameters |> Seq.toList, node.Options |> Seq.toList)
    | _ -> None

  let (|CreateAssembly|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.CreateAssemblyStatement as node ->
      Some (node.Owner)
    | _ -> None

  let (|AlterAssembly|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlterAssemblyStatement as node ->
      Some (node.DropFiles |> Seq.toList, node.IsDropAll, node.AddFiles |> Seq.toList)
    | _ -> None

  let (|AssemblyOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AssemblyOption as node ->
      Some (node.OptionKind)
    | _ -> None

  let (|OnOffAssemblyOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.OnOffAssemblyOption as node ->
      Some (node.OptionState)
    | _ -> None

  let (|PermissionSetAssemblyOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.PermissionSetAssemblyOption as node ->
      Some (node.PermissionSetOption)
    | _ -> None

  let (|AddFileSpec|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AddFileSpec as node ->
      Some (node.File, node.FileName)
    | _ -> None

  let (|CreateXmlSchemaCollection|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.CreateXmlSchemaCollectionStatement as node ->
      Some (node.Name, node.Expression)
    | _ -> None

  let (|AlterXmlSchemaCollection|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlterXmlSchemaCollectionStatement as node ->
      Some (node.Name, node.Expression)
    | _ -> None

  let (|DropXmlSchemaCollection|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.DropXmlSchemaCollectionStatement as node ->
      Some (node.Name)
    | _ -> None

  let (|AssemblyName|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AssemblyName as node ->
      Some (node.Name, node.ClassName)
    | _ -> None

  let (|AlterTable|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlterTableStatement as node ->
      Some (node.SchemaObjectName)
    | _ -> None

  let (|AlterTableAlterPartition|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlterTableAlterPartitionStatement as node ->
      Some (node.BoundaryValue, node.IsSplit)
    | _ -> None

  let (|AlterTableRebuild|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlterTableRebuildStatement as node ->
      Some (node.Partition, node.IndexOptions |> Seq.toList)
    | _ -> None

  let (|AlterTableChangeTrackingModification|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlterTableChangeTrackingModificationStatement as node ->
      Some (node.IsEnable, node.TrackColumnsUpdated)
    | _ -> None

  let (|AlterTableFileTableNamespace|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlterTableFileTableNamespaceStatement as node ->
      Some (node.IsEnable)
    | _ -> None

  let (|AlterTableSet|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlterTableSetStatement as node ->
      Some (node.Options |> Seq.toList)
    | _ -> None

  let (|TableOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.TableOption as node ->
      Some (node.OptionKind)
    | _ -> None

  let (|LockEscalationTableOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.LockEscalationTableOption as node ->
      Some (node.Value)
    | _ -> None

  let (|FileStreamOnTableOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.FileStreamOnTableOption as node ->
      Some (node.Value)
    | _ -> None

  let (|FileTableDirectoryTableOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.FileTableDirectoryTableOption as node ->
      Some (node.Value)
    | _ -> None

  let (|FileTableCollateFileNameTableOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.FileTableCollateFileNameTableOption as node ->
      Some (node.Value)
    | _ -> None

  let (|FileTableConstraintNameTableOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.FileTableConstraintNameTableOption as node ->
      Some (node.Value)
    | _ -> None

  let (|MemoryOptimizedTableOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.MemoryOptimizedTableOption as node ->
      Some (node.OptionState)
    | _ -> None

  let (|DurabilityTableOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.DurabilityTableOption as node ->
      Some (node.DurabilityTableOptionKind)
    | _ -> None

  let (|RemoteDataArchiveTableOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.RemoteDataArchiveTableOption as node ->
      Some (node.RdaTableOption, node.MigrationState)
    | _ -> None

  let (|RemoteDataArchiveAlterTableOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.RemoteDataArchiveAlterTableOption as node ->
      Some (node.RdaTableOption, node.MigrationState, node.IsMigrationStateSpecified, node.IsFilterPredicateSpecified, node.FilterPredicate)
    | _ -> None

  let (|DatabaseOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.DatabaseOption as node ->
      Some (node.OptionKind)
    | _ -> None

  let (|RemoteDataArchiveDatabaseOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.RemoteDataArchiveDatabaseOption as node ->
      Some (node.OptionState, node.Settings |> Seq.toList)
    | _ -> None

  let (|RemoteDataArchiveDatabaseSetting|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.RemoteDataArchiveDatabaseSetting as node ->
      Some (node.SettingKind)
    | _ -> None

  let (|RemoteDataArchiveDbServerSetting|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.RemoteDataArchiveDbServerSetting as node ->
      Some (node.Server)
    | _ -> None

  let (|RemoteDataArchiveDbCredentialSetting|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.RemoteDataArchiveDbCredentialSetting as node ->
      Some (node.Credential)
    | _ -> None

  let (|RemoteDataArchiveDbFederatedServiceAccountSetting|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.RemoteDataArchiveDbFederatedServiceAccountSetting as node ->
      Some (node.IsOn)
    | _ -> None

  let (|RetentionPeriodDef|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.RetentionPeriodDefinition as node ->
      Some (node.Duration, node.Units, node.IsInfinity)
    | _ -> None

  let (|SystemVersioningTableOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.SystemVersioningTableOption as node ->
      Some (node.OptionState, node.ConsistencyCheckEnabled, node.HistoryTable, node.RetentionPeriod)
    | _ -> None

  let (|AlterTableAddTableElement|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlterTableAddTableElementStatement as node ->
      Some (node.ExistingRowsCheckEnforcement, node.Definition)
    | _ -> None

  let (|AlterTableConstraintModification|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlterTableConstraintModificationStatement as node ->
      Some (node.ExistingRowsCheckEnforcement, node.ConstraintEnforcement, node.All, node.ConstraintNames |> Seq.toList)
    | _ -> None

  let (|AlterTableSwitch|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlterTableSwitchStatement as node ->
      Some (node.SourcePartitionNumber, node.TargetPartitionNumber, node.TargetTable, node.Options |> Seq.toList)
    | _ -> None

  let (|TableSwitchOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.TableSwitchOption as node ->
      Some (node.OptionKind)
    | _ -> None

  let (|LowPriorityLockWaitTableSwitchOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.LowPriorityLockWaitTableSwitchOption as node ->
      Some (node.Options |> Seq.toList)
    | _ -> None

  let (|DropClusteredConstraintOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.DropClusteredConstraintOption as node ->
      Some (node.OptionKind)
    | _ -> None

  let (|DropClusteredConstraintStateOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.DropClusteredConstraintStateOption as node ->
      Some (node.OptionState)
    | _ -> None

  let (|DropClusteredConstraintValueOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.DropClusteredConstraintValueOption as node ->
      Some (node.OptionValue)
    | _ -> None

  let (|DropClusteredConstraintMoveOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.DropClusteredConstraintMoveOption as node ->
      Some (node.OptionValue)
    | _ -> None

  let (|DropClusteredConstraintWaitAtLowPriorityLockOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.DropClusteredConstraintWaitAtLowPriorityLockOption as node ->
      Some (node.Options |> Seq.toList)
    | _ -> None

  let (|AlterTableDropTableElement|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlterTableDropTableElement as node ->
      Some (node.TableElementType, node.Name, node.DropClusteredConstraintOptions |> Seq.toList, node.IsIfExists)
    | _ -> None

  let (|AlterTableDropTableElementStatement|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlterTableDropTableElementStatement as node ->
      Some (node.AlterTableDropTableElements |> Seq.toList)
    | _ -> None

  let (|AlterTableTriggerModification|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlterTableTriggerModificationStatement as node ->
      Some (node.TriggerEnforcement, node.All, node.TriggerNames |> Seq.toList)
    | _ -> None

  let (|EnableDisableTrigger|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.EnableDisableTriggerStatement as node ->
      Some (node.TriggerEnforcement, node.All, node.TriggerNames |> Seq.toList, node.TriggerObject)
    | _ -> None

  let (|TryCatch|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.TryCatchStatement as node ->
      Some (node.TryStatements, node.CatchStatements)
    | _ -> None

  let (|CreateType|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.CreateTypeStatement as node ->
      Some (node.Name)
    | _ -> None

  let (|CreateTypeUdt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.CreateTypeUdtStatement as node ->
      Some (node.AssemblyName)
    | _ -> None

  let (|CreateTypeUddt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.CreateTypeUddtStatement as node ->
      Some (node.DataType, node.NullableConstraint)
    | _ -> None

  let (|CreateSynonym|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.CreateSynonymStatement as node ->
      Some (node.Name, node.ForName)
    | _ -> None

  let (|ExecuteAsClause|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ExecuteAsClause as node ->
      Some (node.ExecuteAsOption, node.Literal)
    | _ -> None

  let (|QueueOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.QueueOption as node ->
      Some (node.OptionKind)
    | _ -> None

  let (|QueueStateOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.QueueStateOption as node ->
      Some (node.OptionState)
    | _ -> None

  let (|QueueProcedureOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.QueueProcedureOption as node ->
      Some (node.OptionValue)
    | _ -> None

  let (|QueueValueOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.QueueValueOption as node ->
      Some (node.OptionValue)
    | _ -> None

  let (|QueueExecuteAsOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.QueueExecuteAsOption as node ->
      Some (node.OptionValue)
    | _ -> None

  let (|RouteOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.RouteOption as node ->
      Some (node.OptionKind, node.Literal)
    | _ -> None

  let (|Route|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.RouteStatement as node ->
      Some (node.Name, node.RouteOptions |> Seq.toList)
    | _ -> None

  let (|CreateRoute|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.CreateRouteStatement as node ->
      Some (node.Owner)
    | _ -> None

  let (|Queue|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.QueueStatement as node ->
      Some (node.Name, node.QueueOptions |> Seq.toList)
    | _ -> None

  let (|CreateQueue|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.CreateQueueStatement as node ->
      Some (node.OnFileGroup)
    | _ -> None

  let (|IndexDef|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.IndexDefinition as node ->
      Some (node.Name, node.Unique, node.IndexType, node.IndexOptions |> Seq.toList, node.Columns |> Seq.toList, node.OnFileGroupOrPartitionScheme, node.FilterPredicate, node.FileStreamOn)
    | _ -> None

  let (|SystemTimePeriodDef|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.SystemTimePeriodDefinition as node ->
      Some (node.StartTimeColumn, node.EndTimeColumn)
    | _ -> None

  let (|Index|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.IndexStatement as node ->
      Some (node.Name, node.OnName, node.IndexOptions |> Seq.toList)
    | _ -> None

  let (|IndexType|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.IndexType as node ->
      Some ((if node.IndexTypeKind.HasValue then Some node.IndexTypeKind.Value else None))
    | _ -> None

  let (|PartitionSpecifier|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.PartitionSpecifier as node ->
      Some (node.Number, node.All)
    | _ -> None

  let (|AlterIndex|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlterIndexStatement as node ->
      Some (node.All, node.AlterIndexType, node.Partition, node.PromotedPaths |> Seq.toList, node.XmlNamespaces)
    | _ -> None

  let (|CreateXmlIndex|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.CreateXmlIndexStatement as node ->
      Some (node.Primary, node.XmlColumn, node.SecondaryXmlIndexName, node.SecondaryXmlIndexType)
    | _ -> None

  let (|CreateSelectiveXmlIndex|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.CreateSelectiveXmlIndexStatement as node ->
      Some (node.IsSecondary, node.XmlColumn, node.PromotedPaths |> Seq.toList, node.XmlNamespaces, node.UsingXmlIndexName, node.PathName)
    | _ -> None

  let (|FileGroupOrPartitionScheme|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.FileGroupOrPartitionScheme as node ->
      Some (node.Name, node.PartitionSchemeColumns |> Seq.toList)
    | _ -> None

  let (|CreateIndex|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.CreateIndexStatement as node ->
      Some (node.Translated80SyntaxTo90, node.Unique, (if node.Clustered.HasValue then Some node.Clustered.Value else None), node.Columns |> Seq.toList, node.IncludeColumns |> Seq.toList, node.OnFileGroupOrPartitionScheme, node.FilterPredicate, node.FileStreamOn)
    | _ -> None

  let (|IndexOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.IndexOption as node ->
      Some (node.OptionKind)
    | _ -> None

  let (|IndexStateOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.IndexStateOption as node ->
      Some (node.OptionState)
    | _ -> None

  let (|IndexExpressionOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.IndexExpressionOption as node ->
      Some (node.Expression)
    | _ -> None

  let (|MaxDurationOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.MaxDurationOption as node ->
      Some (node.MaxDuration, (if node.Unit.HasValue then Some node.Unit.Value else None))
    | _ -> None

  let (|WaitAtLowPriorityOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.WaitAtLowPriorityOption as node ->
      Some (node.Options |> Seq.toList)
    | _ -> None

  let (|OnlineIndexOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.OnlineIndexOption as node ->
      Some (node.LowPriorityLockWaitOption)
    | _ -> None

  let (|IgnoreDupKeyIndexOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.IgnoreDupKeyIndexOption as node ->
      Some ((if node.SuppressMessagesOption.HasValue then Some node.SuppressMessagesOption.Value else None))
    | _ -> None

  let (|OrderIndexOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.OrderIndexOption as node ->
      Some (node.Columns |> Seq.toList)
    | _ -> None

  let (|OnlineIndexLowPriorityLockWaitOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.OnlineIndexLowPriorityLockWaitOption as node ->
      Some (node.Options |> Seq.toList)
    | _ -> None

  let (|LowPriorityLockWaitOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.LowPriorityLockWaitOption as node ->
      Some (node.OptionKind)
    | _ -> None

  let (|LowPriorityLockWaitMaxDurationOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.LowPriorityLockWaitMaxDurationOption as node ->
      Some (node.MaxDuration, (if node.Unit.HasValue then Some node.Unit.Value else None))
    | _ -> None

  let (|LowPriorityLockWaitAbortAfterWaitOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.LowPriorityLockWaitAbortAfterWaitOption as node ->
      Some (node.AbortAfterWait)
    | _ -> None

  let (|FullTextIndexColumn|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.FullTextIndexColumn as node ->
      Some (node.Name, node.TypeColumn, node.LanguageTerm, node.StatisticalSemantics)
    | _ -> None

  let (|CreateFullTextIndex|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.CreateFullTextIndexStatement as node ->
      Some (node.OnName, node.FullTextIndexColumns |> Seq.toList, node.KeyIndexName, node.CatalogAndFileGroup, node.Options |> Seq.toList)
    | _ -> None

  let (|FullTextIndexOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.FullTextIndexOption as node ->
      Some (node.OptionKind)
    | _ -> None

  let (|ChangeTrackingFullTextIndexOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ChangeTrackingFullTextIndexOption as node ->
      Some (node.Value)
    | _ -> None

  let (|StopListFullTextIndexOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.StopListFullTextIndexOption as node ->
      Some (node.IsOff, node.StopListName)
    | _ -> None

  let (|SearchPropertyListFullTextIndexOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.SearchPropertyListFullTextIndexOption as node ->
      Some (node.IsOff, node.PropertyListName)
    | _ -> None

  let (|FullTextCatalogAndFileGroup|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.FullTextCatalogAndFileGroup as node ->
      Some (node.CatalogName, node.FileGroupName, node.FileGroupIsFirst)
    | _ -> None

  let (|EventTypeContainer|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.EventTypeContainer as node ->
      Some (node.EventType)
    | _ -> None

  let (|EventGroupContainer|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.EventGroupContainer as node ->
      Some (node.EventGroup)
    | _ -> None

  let (|CreateEventNotification|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.CreateEventNotificationStatement as node ->
      Some (node.Name, node.Scope, node.WithFanIn, node.EventTypeGroups |> Seq.toList, node.BrokerService, node.BrokerInstanceSpecifier)
    | _ -> None

  let (|EventNotificationObjectScope|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.EventNotificationObjectScope as node ->
      Some (node.Target, node.QueueName)
    | _ -> None

  let (|MasterKey|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.MasterKeyStatement as node ->
      Some (node.Password)
    | _ -> None

  let (|AlterMasterKey|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlterMasterKeyStatement as node ->
      Some (node.Option)
    | _ -> None

  let (|ApplicationRoleOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ApplicationRoleOption as node ->
      Some (node.OptionKind, node.Value)
    | _ -> None

  let (|ApplicationRole|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ApplicationRoleStatement as node ->
      Some (node.Name, node.ApplicationRoleOptions |> Seq.toList)
    | _ -> None

  let (|Role|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.RoleStatement as node ->
      Some (node.Name)
    | _ -> None

  let (|CreateRole|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.CreateRoleStatement as node ->
      Some (node.Owner)
    | _ -> None

  let (|AlterRole|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlterRoleStatement as node ->
      Some (node.Action)
    | _ -> None

  let (|RenameAlterRoleAction|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.RenameAlterRoleAction as node ->
      Some (node.NewName)
    | _ -> None

  let (|AddMemberAlterRoleAction|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AddMemberAlterRoleAction as node ->
      Some (node.Member)
    | _ -> None

  let (|DropMemberAlterRoleAction|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.DropMemberAlterRoleAction as node ->
      Some (node.Member)
    | _ -> None

  let (|UserLoginOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.UserLoginOption as node ->
      Some (node.UserLoginOptionType, node.Identifier)
    | _ -> None

  let (|User|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.UserStatement as node ->
      Some (node.Name, node.UserOptions |> Seq.toList)
    | _ -> None

  let (|CreateUser|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.CreateUserStatement as node ->
      Some (node.UserLoginOption)
    | _ -> None

  let (|StatisticsOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.StatisticsOption as node ->
      Some (node.OptionKind)
    | _ -> None

  let (|ResampleStatisticsOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ResampleStatisticsOption as node ->
      Some (node.Partitions |> Seq.toList)
    | _ -> None

  let (|StatisticsPartitionRange|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.StatisticsPartitionRange as node ->
      Some (node.From, node.To)
    | _ -> None

  let (|OnOffStatisticsOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.OnOffStatisticsOption as node ->
      Some (node.OptionState)
    | _ -> None

  let (|LiteralStatisticsOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.LiteralStatisticsOption as node ->
      Some (node.Literal)
    | _ -> None

  let (|CreateStatistics|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.CreateStatisticsStatement as node ->
      Some (node.Name, node.OnName, node.Columns |> Seq.toList, node.StatisticsOptions |> Seq.toList, node.FilterPredicate)
    | _ -> None

  let (|UpdateStatistics|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.UpdateStatisticsStatement as node ->
      Some (node.SchemaObjectName, node.SubElements |> Seq.toList, node.StatisticsOptions |> Seq.toList)
    | _ -> None

  let (|Return|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ReturnStatement as node ->
      Some (node.Expression)
    | _ -> None

  let (|DeclareCursor|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.DeclareCursorStatement as node ->
      Some (node.Name, node.CursorDefinition)
    | _ -> None

  let (|CursorDef|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.CursorDefinition as node ->
      Some (node.Options |> Seq.toList, node.Select)
    | _ -> None

  let (|CursorOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.CursorOption as node ->
      Some (node.OptionKind)
    | _ -> None

  let (|SetVariable|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.SetVariableStatement as node ->
      Some (node.Variable, node.SeparatorType, node.Identifier, node.FunctionCallExists, node.Parameters |> Seq.toList, node.Expression, node.CursorDefinition, node.AssignmentKind)
    | _ -> None

  let (|CursorId|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.CursorId as node ->
      Some (node.IsGlobal, node.Name)
    | _ -> None

  let (|Cursor|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.CursorStatement as node ->
      Some (node.Cursor)
    | _ -> None

  let (|CryptoMechanism|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.CryptoMechanism as node ->
      Some (node.CryptoMechanismType, node.Identifier, node.PasswordOrSignature)
    | _ -> None

  let (|OpenSymmetricKey|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.OpenSymmetricKeyStatement as node ->
      Some (node.Name, node.DecryptionMechanism)
    | _ -> None

  let (|CloseSymmetricKey|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.CloseSymmetricKeyStatement as node ->
      Some (node.Name, node.All)
    | _ -> None

  let (|OpenMasterKey|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.OpenMasterKeyStatement as node ->
      Some (node.Password)
    | _ -> None

  let (|FetchType|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.FetchType as node ->
      Some (node.Orientation, node.RowOffset)
    | _ -> None

  let (|FetchCursor|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.FetchCursorStatement as node ->
      Some (node.FetchType, node.IntoVariables |> Seq.toList)
    | _ -> None

  let (|WhereClause|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.WhereClause as node ->
      Some (node.SearchCondition, node.Cursor)
    | _ -> None

  let (|DropDatabase|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.DropDatabaseStatement as node ->
      Some (node.Databases |> Seq.toList, node.IsIfExists)
    | _ -> None

  let (|DropChildObjects|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.DropChildObjectsStatement as node ->
      Some (node.Objects |> Seq.toList)
    | _ -> None

  let (|DropIndex|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.DropIndexStatement as node ->
      Some (node.DropIndexClauses |> Seq.toList, node.IsIfExists)
    | _ -> None

  let (|BackwardsCompatibleDropIndexClause|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.BackwardsCompatibleDropIndexClause as node ->
      Some (node.Index)
    | _ -> None

  let (|DropIndexClause|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.DropIndexClause as node ->
      Some (node.Index, node.Object, node.Options |> Seq.toList)
    | _ -> None

  let (|MoveToDropIndexOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.MoveToDropIndexOption as node ->
      Some (node.MoveTo)
    | _ -> None

  let (|FileStreamOnDropIndexOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.FileStreamOnDropIndexOption as node ->
      Some (node.FileStreamOn)
    | _ -> None

  let (|DropTrigger|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.DropTriggerStatement as node ->
      Some (node.TriggerScope)
    | _ -> None

  let (|DropSchema|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.DropSchemaStatement as node ->
      Some (node.Schema, node.DropBehavior, node.IsIfExists)
    | _ -> None

  let (|RaiseErrorLegacy|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.RaiseErrorLegacyStatement as node ->
      Some (node.FirstParameter, node.SecondParameter)
    | _ -> None

  let (|RaiseError|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.RaiseErrorStatement as node ->
      Some (node.FirstParameter, node.SecondParameter, node.ThirdParameter, node.OptionalParameters |> Seq.toList, node.RaiseErrorOptions)
    | _ -> None

  let (|Throw|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ThrowStatement as node ->
      Some (node.ErrorNumber, node.Message, node.State)
    | _ -> None

  let (|Use|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.UseStatement as node ->
      Some (node.DatabaseName)
    | _ -> None

  let (|Kill|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.KillStatement as node ->
      Some (node.Parameter, node.WithStatusOnly)
    | _ -> None

  let (|KillQueryNotificationSubscription|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.KillQueryNotificationSubscriptionStatement as node ->
      Some (node.SubscriptionId, node.All)
    | _ -> None

  let (|KillStatsJob|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.KillStatsJobStatement as node ->
      Some (node.JobId)
    | _ -> None

  let (|Checkpoint|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.CheckpointStatement as node ->
      Some (node.Duration)
    | _ -> None

  let (|Reconfigure|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ReconfigureStatement as node ->
      Some (node.WithOverride)
    | _ -> None

  let (|Shutdown|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ShutdownStatement as node ->
      Some (node.WithNoWait)
    | _ -> None

  let (|SetUser|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.SetUserStatement as node ->
      Some (node.UserName, node.WithNoReset)
    | _ -> None

  let (|TruncateTable|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.TruncateTableStatement as node ->
      Some (node.TableName, node.PartitionRanges |> Seq.toList)
    | _ -> None

  let (|SetOnOff|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.SetOnOffStatement as node ->
      Some (node.IsOn)
    | _ -> None

  let (|PredicateSet|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.PredicateSetStatement as node ->
      Some (node.Options)
    | _ -> None

  let (|SetStatistics|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.SetStatisticsStatement as node ->
      Some (node.Options)
    | _ -> None

  let (|SetRowCount|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.SetRowCountStatement as node ->
      Some (node.NumberRows)
    | _ -> None

  let (|SetOffsets|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.SetOffsetsStatement as node ->
      Some (node.Options)
    | _ -> None

  let (|GeneralSetCommand|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.GeneralSetCommand as node ->
      Some (node.CommandType, node.Parameter)
    | _ -> None

  let (|SetFipsFlaggerCommand|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.SetFipsFlaggerCommand as node ->
      Some (node.ComplianceLevel)
    | _ -> None

  let (|SetCommand|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.SetCommandStatement as node ->
      Some (node.Commands |> Seq.toList)
    | _ -> None

  let (|SetTransactionIsolationLevel|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.SetTransactionIsolationLevelStatement as node ->
      Some (node.Level)
    | _ -> None

  let (|SetTextSize|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.SetTextSizeStatement as node ->
      Some (node.TextSize)
    | _ -> None

  let (|SetIdentityInsert|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.SetIdentityInsertStatement as node ->
      Some (node.Table)
    | _ -> None

  let (|SetErrorLevel|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.SetErrorLevelStatement as node ->
      Some (node.Level)
    | _ -> None

  let (|CreateDatabase|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.CreateDatabaseStatement as node ->
      Some (node.DatabaseName, node.Containment, node.FileGroups |> Seq.toList, node.LogOn |> Seq.toList, node.Options |> Seq.toList, node.AttachMode, node.DatabaseSnapshot, node.CopyOf, node.Collation)
    | _ -> None

  let (|FileDeclaration|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.FileDeclaration as node ->
      Some (node.Options |> Seq.toList, node.IsPrimary)
    | _ -> None

  let (|FileDeclarationOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.FileDeclarationOption as node ->
      Some (node.OptionKind)
    | _ -> None

  let (|NameFileDeclarationOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.NameFileDeclarationOption as node ->
      Some (node.LogicalFileName, node.IsNewName)
    | _ -> None

  let (|FileNameFileDeclarationOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.FileNameFileDeclarationOption as node ->
      Some (node.OSFileName)
    | _ -> None

  let (|SizeFileDeclarationOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.SizeFileDeclarationOption as node ->
      Some (node.Size, node.Units)
    | _ -> None

  let (|MaxSizeFileDeclarationOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.MaxSizeFileDeclarationOption as node ->
      Some (node.MaxSize, node.Units, node.Unlimited)
    | _ -> None

  let (|FileGrowthFileDeclarationOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.FileGrowthFileDeclarationOption as node ->
      Some (node.GrowthIncrement, node.Units)
    | _ -> None

  let (|FileGroupDef|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.FileGroupDefinition as node ->
      Some (node.Name, node.FileDeclarations |> Seq.toList, node.IsDefault, node.ContainsFileStream, node.ContainsMemoryOptimizedData)
    | _ -> None

  let (|AlterDatabase|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlterDatabaseStatement as node ->
      Some (node.DatabaseName, node.UseCurrent)
    | _ -> None

  let (|AlterDatabaseScopedConfiguration|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlterDatabaseScopedConfigurationStatement as node ->
      Some (node.Secondary)
    | _ -> None

  let (|AlterDatabaseScopedConfigurationSet|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlterDatabaseScopedConfigurationSetStatement as node ->
      Some (node.Option)
    | _ -> None

  let (|AlterDatabaseScopedConfigurationClear|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlterDatabaseScopedConfigurationClearStatement as node ->
      Some (node.Option)
    | _ -> None

  let (|DatabaseConfigurationClearOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.DatabaseConfigurationClearOption as node ->
      Some (node.OptionKind, node.PlanHandle)
    | _ -> None

  let (|DatabaseConfigurationSetOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.DatabaseConfigurationSetOption as node ->
      Some (node.OptionKind, node.GenericOptionKind)
    | _ -> None

  let (|OnOffPrimaryConfigurationOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.OnOffPrimaryConfigurationOption as node ->
      Some (node.OptionState)
    | _ -> None

  let (|MaxDopConfigurationOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.MaxDopConfigurationOption as node ->
      Some (node.Value, node.Primary)
    | _ -> None

  let (|GenericConfigurationOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.GenericConfigurationOption as node ->
      Some (node.GenericOptionState)
    | _ -> None

  let (|AlterDatabaseCollate|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlterDatabaseCollateStatement as node ->
      Some (node.Collation)
    | _ -> None

  let (|AlterDatabaseRebuildLog|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlterDatabaseRebuildLogStatement as node ->
      Some (node.FileDeclaration)
    | _ -> None

  let (|AlterDatabaseAddFile|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlterDatabaseAddFileStatement as node ->
      Some (node.FileDeclarations |> Seq.toList, node.FileGroup, node.IsLog)
    | _ -> None

  let (|AlterDatabaseAddFileGroup|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlterDatabaseAddFileGroupStatement as node ->
      Some (node.FileGroup, node.ContainsFileStream, node.ContainsMemoryOptimizedData)
    | _ -> None

  let (|AlterDatabaseRemoveFileGroup|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlterDatabaseRemoveFileGroupStatement as node ->
      Some (node.FileGroup)
    | _ -> None

  let (|AlterDatabaseRemoveFile|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlterDatabaseRemoveFileStatement as node ->
      Some (node.File)
    | _ -> None

  let (|AlterDatabaseModifyName|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlterDatabaseModifyNameStatement as node ->
      Some (node.NewDatabaseName)
    | _ -> None

  let (|AlterDatabaseModifyFile|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlterDatabaseModifyFileStatement as node ->
      Some (node.FileDeclaration)
    | _ -> None

  let (|AlterDatabaseModifyFileGroup|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlterDatabaseModifyFileGroupStatement as node ->
      Some (node.FileGroup, node.NewFileGroupName, node.MakeDefault, node.UpdatabilityOption, node.Termination)
    | _ -> None

  let (|AlterDatabaseTermination|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlterDatabaseTermination as node ->
      Some (node.ImmediateRollback, node.RollbackAfter, node.NoWait)
    | _ -> None

  let (|AlterDatabaseSet|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlterDatabaseSetStatement as node ->
      Some (node.Termination, node.Options |> Seq.toList)
    | _ -> None

  let (|OnOffDatabaseOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.OnOffDatabaseOption as node ->
      Some (node.OptionState)
    | _ -> None

  let (|AutoCreateStatisticsDatabaseOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AutoCreateStatisticsDatabaseOption as node ->
      Some (node.HasIncremental, node.IncrementalState)
    | _ -> None

  let (|ContainmentDatabaseOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ContainmentDatabaseOption as node ->
      Some (node.Value)
    | _ -> None

  let (|HadrDatabaseOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.HadrDatabaseOption as node ->
      Some (node.HadrOption)
    | _ -> None

  let (|HadrAvailabilityGroupDatabaseOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.HadrAvailabilityGroupDatabaseOption as node ->
      Some (node.GroupName)
    | _ -> None

  let (|DelayedDurabilityDatabaseOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.DelayedDurabilityDatabaseOption as node ->
      Some (node.Value)
    | _ -> None

  let (|CursorDefaultDatabaseOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.CursorDefaultDatabaseOption as node ->
      Some (node.IsLocal)
    | _ -> None

  let (|RecoveryDatabaseOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.RecoveryDatabaseOption as node ->
      Some (node.Value)
    | _ -> None

  let (|TargetRecoveryTimeDatabaseOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.TargetRecoveryTimeDatabaseOption as node ->
      Some (node.RecoveryTime, node.Unit)
    | _ -> None

  let (|PageVerifyDatabaseOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.PageVerifyDatabaseOption as node ->
      Some (node.Value)
    | _ -> None

  let (|PartnerDatabaseOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.PartnerDatabaseOption as node ->
      Some (node.PartnerServer, node.PartnerOption, node.Timeout)
    | _ -> None

  let (|WitnessDatabaseOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.WitnessDatabaseOption as node ->
      Some (node.WitnessServer, node.IsOff)
    | _ -> None

  let (|ParameterizationDatabaseOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ParameterizationDatabaseOption as node ->
      Some (node.IsSimple)
    | _ -> None

  let (|LiteralDatabaseOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.LiteralDatabaseOption as node ->
      Some (node.Value)
    | _ -> None

  let (|IdentifierDatabaseOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.IdentifierDatabaseOption as node ->
      Some (node.Value)
    | _ -> None

  let (|ChangeTrackingDatabaseOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ChangeTrackingDatabaseOption as node ->
      Some (node.OptionState, node.Details |> Seq.toList)
    | _ -> None

  let (|AutoCleanupChangeTrackingOptionDetail|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AutoCleanupChangeTrackingOptionDetail as node ->
      Some (node.IsOn)
    | _ -> None

  let (|ChangeRetentionChangeTrackingOptionDetail|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ChangeRetentionChangeTrackingOptionDetail as node ->
      Some (node.RetentionPeriod, node.Unit)
    | _ -> None

  let (|QueryStoreDatabaseOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.QueryStoreDatabaseOption as node ->
      Some (node.Clear, node.ClearAll, node.OptionState, node.Options |> Seq.toList)
    | _ -> None

  let (|QueryStoreOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.QueryStoreOption as node ->
      Some (node.OptionKind)
    | _ -> None

  let (|QueryStoreDesiredStateOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.QueryStoreDesiredStateOption as node ->
      Some (node.Value, node.OperationModeSpecified)
    | _ -> None

  let (|QueryStoreCapturePolicyOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.QueryStoreCapturePolicyOption as node ->
      Some (node.Value)
    | _ -> None

  let (|QueryStoreSizeCleanupPolicyOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.QueryStoreSizeCleanupPolicyOption as node ->
      Some (node.Value)
    | _ -> None

  let (|QueryStoreDataFlushIntervalOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.QueryStoreDataFlushIntervalOption as node ->
      Some (node.FlushInterval)
    | _ -> None

  let (|QueryStoreIntervalLengthOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.QueryStoreIntervalLengthOption as node ->
      Some (node.StatsIntervalLength)
    | _ -> None

  let (|QueryStoreMaxStorageSizeOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.QueryStoreMaxStorageSizeOption as node ->
      Some (node.MaxQdsSize)
    | _ -> None

  let (|QueryStoreMaxPlansPerQueryOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.QueryStoreMaxPlansPerQueryOption as node ->
      Some (node.MaxPlansPerQuery)
    | _ -> None

  let (|QueryStoreTimeCleanupPolicyOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.QueryStoreTimeCleanupPolicyOption as node ->
      Some (node.StaleQueryThreshold)
    | _ -> None

  let (|AutomaticTuningDatabaseOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AutomaticTuningDatabaseOption as node ->
      Some (node.AutomaticTuningState, node.Options |> Seq.toList)
    | _ -> None

  let (|AutomaticTuningOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AutomaticTuningOption as node ->
      Some (node.OptionKind, node.Value)
    | _ -> None

  let (|FileStreamDatabaseOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.FileStreamDatabaseOption as node ->
      Some ((if node.NonTransactedAccess.HasValue then Some node.NonTransactedAccess.Value else None), node.DirectoryName)
    | _ -> None

  let (|CatalogCollationOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.CatalogCollationOption as node ->
      Some ((if node.CatalogCollation.HasValue then Some node.CatalogCollation.Value else None))
    | _ -> None

  let (|MaxSizeDatabaseOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.MaxSizeDatabaseOption as node ->
      Some (node.MaxSize, node.Units)
    | _ -> None

  let (|AlterTableAlterIndex|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlterTableAlterIndexStatement as node ->
      Some (node.IndexIdentifier, node.AlterIndexType, node.IndexOptions |> Seq.toList)
    | _ -> None

  let (|AlterTableAlterColumn|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlterTableAlterColumnStatement as node ->
      Some (node.ColumnIdentifier, node.DataType, node.AlterTableAlterColumnOption, node.StorageOptions, node.Options |> Seq.toList, (if node.GeneratedAlways.HasValue then Some node.GeneratedAlways.Value else None), node.IsHidden, node.Encryption, node.Collation, node.IsMasked, node.MaskingFunction)
    | _ -> None

  let (|ColumnDefinitionBase|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ColumnDefinitionBase as node ->
      Some (node.ColumnIdentifier, node.DataType, node.Collation)
    | _ -> None

  let (|ColumnDef|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ColumnDefinition as node ->
      Some (node.ComputedColumnExpression, node.IsPersisted, node.DefaultConstraint, node.IdentityOptions, node.IsRowGuidCol, node.Constraints |> Seq.toList, node.StorageOptions, node.Index, (if node.GeneratedAlways.HasValue then Some node.GeneratedAlways.Value else None), node.IsHidden, node.Encryption, node.IsMasked, node.MaskingFunction)
    | _ -> None

  let (|ColumnEncryptionDef|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ColumnEncryptionDefinition as node ->
      Some (node.Parameters |> Seq.toList)
    | _ -> None

  let (|ColumnEncryptionDefinitionParameter|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ColumnEncryptionDefinitionParameter as node ->
      Some (node.ParameterKind)
    | _ -> None

  let (|ColumnEncryptionKeyNameParameter|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ColumnEncryptionKeyNameParameter as node ->
      Some (node.Name)
    | _ -> None

  let (|ColumnEncryptionTypeParameter|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ColumnEncryptionTypeParameter as node ->
      Some (node.EncryptionType)
    | _ -> None

  let (|ColumnEncryptionAlgorithmParameter|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ColumnEncryptionAlgorithmParameter as node ->
      Some (node.EncryptionAlgorithm)
    | _ -> None

  let (|IdentityOptions|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.IdentityOptions as node ->
      Some (node.IdentitySeed, node.IdentityIncrement, node.IsIdentityNotForReplication)
    | _ -> None

  let (|ColumnStorageOptions|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ColumnStorageOptions as node ->
      Some (node.IsFileStream, node.SparseOption)
    | _ -> None

  let (|ConstraintDef|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ConstraintDefinition as node ->
      Some (node.ConstraintIdentifier)
    | _ -> None

  let (|CreateTable|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.CreateTableStatement as node ->
      Some (node.SchemaObjectName, node.AsEdge, node.AsFileTable, node.AsNode, node.Definition, node.OnFileGroupOrPartitionScheme, node.FederationScheme, node.TextImageOn, node.Options |> Seq.toList, node.FileStreamOn)
    | _ -> None

  let (|FederationScheme|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.FederationScheme as node ->
      Some (node.DistributionName, node.ColumnName)
    | _ -> None

  let (|TableDataCompressionOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.TableDataCompressionOption as node ->
      Some (node.DataCompressionOption)
    | _ -> None

  let (|TableDistributionOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.TableDistributionOption as node ->
      Some (node.Value)
    | _ -> None

  let (|TableHashDistributionPolicy|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.TableHashDistributionPolicy as node ->
      Some (node.DistributionColumn)
    | _ -> None

  let (|TableIndexOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.TableIndexOption as node ->
      Some (node.Value)
    | _ -> None

  let (|TableClusteredIndexType|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.TableClusteredIndexType as node ->
      Some (node.Columns |> Seq.toList, node.ColumnStore)
    | _ -> None

  let (|TablePartitionOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.TablePartitionOption as node ->
      Some (node.PartitionColumn, node.PartitionOptionSpecs)
    | _ -> None

  let (|TablePartitionOptionSpecifications|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.TablePartitionOptionSpecifications as node ->
      Some (node.Range, node.BoundaryValues |> Seq.toList)
    | _ -> None

  let (|DataCompressionOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.DataCompressionOption as node ->
      Some (node.CompressionLevel, node.PartitionRanges |> Seq.toList)
    | _ -> None

  let (|CompressionPartitionRange|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.CompressionPartitionRange as node ->
      Some (node.From, node.To)
    | _ -> None

  let (|CheckConstraintDef|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.CheckConstraintDefinition as node ->
      Some (node.CheckCondition, node.NotForReplication)
    | _ -> None

  let (|DefaultConstraintDef|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.DefaultConstraintDefinition as node ->
      Some (node.Expression, node.WithValues, node.Column)
    | _ -> None

  let (|ForeignKeyConstraintDef|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ForeignKeyConstraintDefinition as node ->
      Some (node.Columns |> Seq.toList, node.ReferenceTableName, node.ReferencedTableColumns |> Seq.toList, node.DeleteAction, node.UpdateAction, node.NotForReplication)
    | _ -> None

  let (|NullableConstraintDef|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.NullableConstraintDefinition as node ->
      Some (node.Nullable)
    | _ -> None

  let (|GraphConnectionBetweenNodes|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.GraphConnectionBetweenNodes as node ->
      Some (node.FromNode, node.ToNode)
    | _ -> None

  let (|GraphConnectionConstraintDef|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.GraphConnectionConstraintDefinition as node ->
      Some (node.FromNodeToNodeList |> Seq.toList)
    | _ -> None

  let (|UniqueConstraintDef|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.UniqueConstraintDefinition as node ->
      Some ((if node.Clustered.HasValue then Some node.Clustered.Value else None), node.IsPrimaryKey, node.Columns |> Seq.toList, node.IndexOptions |> Seq.toList, node.OnFileGroupOrPartitionScheme, node.IndexType, node.FileStreamOn)
    | _ -> None

  let (|Backup|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.BackupStatement as node ->
      Some (node.DatabaseName, node.Options |> Seq.toList, node.MirrorToClauses |> Seq.toList, node.Devices |> Seq.toList)
    | _ -> None

  let (|BackupDatabase|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.BackupDatabaseStatement as node ->
      Some (node.Files |> Seq.toList)
    | _ -> None

  let (|Restore|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.RestoreStatement as node ->
      Some (node.DatabaseName, node.Devices |> Seq.toList, node.Files |> Seq.toList, node.Options |> Seq.toList, node.Kind)
    | _ -> None

  let (|RestoreOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.RestoreOption as node ->
      Some (node.OptionKind)
    | _ -> None

  let (|ScalarExpressionRestoreOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ScalarExpressionRestoreOption as node ->
      Some (node.Value)
    | _ -> None

  let (|MoveRestoreOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.MoveRestoreOption as node ->
      Some (node.LogicalFileName, node.OSFileName)
    | _ -> None

  let (|StopRestoreOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.StopRestoreOption as node ->
      Some (node.Mark, node.After, node.IsStopAt)
    | _ -> None

  let (|FileStreamRestoreOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.FileStreamRestoreOption as node ->
      Some (node.FileStreamOption)
    | _ -> None

  let (|BackupOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.BackupOption as node ->
      Some (node.OptionKind, node.Value)
    | _ -> None

  let (|BackupEncryptionOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.BackupEncryptionOption as node ->
      Some (node.Algorithm, node.Encryptor)
    | _ -> None

  let (|DeviceInfo|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.DeviceInfo as node ->
      Some (node.LogicalDevice, node.PhysicalDevice, node.DeviceType)
    | _ -> None

  let (|MirrorToClause|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.MirrorToClause as node ->
      Some (node.Devices |> Seq.toList)
    | _ -> None

  let (|BackupRestoreFileInfo|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.BackupRestoreFileInfo as node ->
      Some (node.Items |> Seq.toList, node.ItemKind)
    | _ -> None

  let (|BulkInsertBase|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.BulkInsertBase as node ->
      Some (node.To, node.Options |> Seq.toList)
    | _ -> None

  let (|BulkInsert|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.BulkInsertStatement as node ->
      Some (node.From)
    | _ -> None

  let (|InsertBulk|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.InsertBulkStatement as node ->
      Some (node.ColumnDefinitions |> Seq.toList)
    | _ -> None

  let (|BulkInsertOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.BulkInsertOption as node ->
      Some (node.OptionKind)
    | _ -> None

  let (|LiteralBulkInsertOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.LiteralBulkInsertOption as node ->
      Some (node.Value)
    | _ -> None

  let (|OrderBulkInsertOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.OrderBulkInsertOption as node ->
      Some (node.Columns |> Seq.toList, node.IsUnique)
    | _ -> None

  let (|ExternalTableColumnDef|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ExternalTableColumnDefinition as node ->
      Some (node.ColumnDefinition, node.NullableConstraint)
    | _ -> None

  let (|InsertBulkColumnDef|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.InsertBulkColumnDefinition as node ->
      Some (node.Column, node.NullNotNull)
    | _ -> None

  let (|Dbcc|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.DbccStatement as node ->
      Some (node.DllName, node.Command, node.ParenthesisRequired, node.Literals |> Seq.toList, node.Options |> Seq.toList, node.OptionsUseJoin)
    | _ -> None

  let (|DbccOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.DbccOption as node ->
      Some (node.OptionKind)
    | _ -> None

  let (|DbccNamedLiteral|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.DbccNamedLiteral as node ->
      Some (node.Name, node.Value)
    | _ -> None

  let (|CreateAsymmetricKey|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.CreateAsymmetricKeyStatement as node ->
      Some (node.Name, node.KeySource, node.EncryptionAlgorithm, node.Password, node.Owner)
    | _ -> None

  let (|CreatePartitionFunction|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.CreatePartitionFunctionStatement as node ->
      Some (node.Name, node.ParameterType, node.Range, node.BoundaryValues |> Seq.toList)
    | _ -> None

  let (|PartitionParameterType|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.PartitionParameterType as node ->
      Some (node.DataType, node.Collation)
    | _ -> None

  let (|CreatePartitionScheme|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.CreatePartitionSchemeStatement as node ->
      Some (node.Name, node.PartitionFunction, node.IsAll, node.FileGroups |> Seq.toList)
    | _ -> None

  let (|RemoteServiceBindingStatementBase|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.RemoteServiceBindingStatementBase as node ->
      Some (node.Name, node.Options |> Seq.toList)
    | _ -> None

  let (|RemoteServiceBindingOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.RemoteServiceBindingOption as node ->
      Some (node.OptionKind)
    | _ -> None

  let (|OnOffRemoteServiceBindingOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.OnOffRemoteServiceBindingOption as node ->
      Some (node.OptionState)
    | _ -> None

  let (|UserRemoteServiceBindingOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.UserRemoteServiceBindingOption as node ->
      Some (node.User)
    | _ -> None

  let (|CreateRemoteServiceBinding|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.CreateRemoteServiceBindingStatement as node ->
      Some (node.Service, node.Owner)
    | _ -> None

  let (|AssemblyEncryptionSource|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AssemblyEncryptionSource as node ->
      Some (node.Assembly)
    | _ -> None

  let (|FileEncryptionSource|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.FileEncryptionSource as node ->
      Some (node.IsExecutable, node.File)
    | _ -> None

  let (|ProviderEncryptionSource|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ProviderEncryptionSource as node ->
      Some (node.Name, node.KeyOptions |> Seq.toList)
    | _ -> None

  let (|CertificateStatementBase|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.CertificateStatementBase as node ->
      Some (node.Name, node.ActiveForBeginDialog, node.PrivateKeyPath, node.EncryptionPassword, node.DecryptionPassword)
    | _ -> None

  let (|AlterCertificate|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlterCertificateStatement as node ->
      Some (node.Kind, node.AttestedBy)
    | _ -> None

  let (|CreateCertificate|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.CreateCertificateStatement as node ->
      Some (node.CertificateSource, node.CertificateOptions |> Seq.toList, node.Owner)
    | _ -> None

  let (|CertificateOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.CertificateOption as node ->
      Some (node.Kind, node.Value)
    | _ -> None

  let (|CreateContract|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.CreateContractStatement as node ->
      Some (node.Name, node.Messages |> Seq.toList, node.Owner)
    | _ -> None

  let (|ContractMessage|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ContractMessage as node ->
      Some (node.Name, node.SentBy)
    | _ -> None

  let (|Credential|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.CredentialStatement as node ->
      Some (node.Name, node.Identity, node.Secret, node.IsDatabaseScoped)
    | _ -> None

  let (|CreateCredential|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.CreateCredentialStatement as node ->
      Some (node.CryptographicProviderName)
    | _ -> None

  let (|MessageTypeStatementBase|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.MessageTypeStatementBase as node ->
      Some (node.Name, node.ValidationMethod, node.XmlSchemaCollectionName)
    | _ -> None

  let (|CreateMessageType|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.CreateMessageTypeStatement as node ->
      Some (node.Owner)
    | _ -> None

  let (|CreateAggregate|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.CreateAggregateStatement as node ->
      Some (node.Name, node.AssemblyName, node.Parameters |> Seq.toList, node.ReturnType)
    | _ -> None

  let (|AlterCreateEndpointStatementBase|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlterCreateEndpointStatementBase as node ->
      Some (node.Name, node.State, node.Affinity, node.Protocol, node.ProtocolOptions |> Seq.toList, node.EndpointType, node.PayloadOptions |> Seq.toList)
    | _ -> None

  let (|CreateEndpoint|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.CreateEndpointStatement as node ->
      Some (node.Owner)
    | _ -> None

  let (|EndpointAffinity|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.EndpointAffinity as node ->
      Some (node.Kind, node.Value)
    | _ -> None

  let (|EndpointProtocolOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.EndpointProtocolOption as node ->
      Some (node.Kind)
    | _ -> None

  let (|LiteralEndpointProtocolOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.LiteralEndpointProtocolOption as node ->
      Some (node.Value)
    | _ -> None

  let (|AuthenticationEndpointProtocolOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AuthenticationEndpointProtocolOption as node ->
      Some (node.AuthenticationTypes)
    | _ -> None

  let (|PortsEndpointProtocolOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.PortsEndpointProtocolOption as node ->
      Some (node.PortTypes)
    | _ -> None

  let (|CompressionEndpointProtocolOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.CompressionEndpointProtocolOption as node ->
      Some (node.IsEnabled)
    | _ -> None

  let (|ListenerIPEndpointProtocolOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ListenerIPEndpointProtocolOption as node ->
      Some (node.IsAll, node.IPv6, node.IPv4PartOne, node.IPv4PartTwo)
    | _ -> None

  let (|IPv4|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.IPv4 as node ->
      Some (node.OctetOne, node.OctetTwo, node.OctetThree, node.OctetFour)
    | _ -> None

  let (|PayloadOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.PayloadOption as node ->
      Some (node.Kind)
    | _ -> None

  let (|SoapMethod|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.SoapMethod as node ->
      Some (node.Alias, node.Namespace, node.Action, node.Name, node.Format, node.Schema)
    | _ -> None

  let (|EnabledDisabledPayloadOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.EnabledDisabledPayloadOption as node ->
      Some (node.IsEnabled)
    | _ -> None

  let (|WsdlPayloadOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.WsdlPayloadOption as node ->
      Some (node.IsNone, node.Value)
    | _ -> None

  let (|LoginTypePayloadOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.LoginTypePayloadOption as node ->
      Some (node.IsWindows)
    | _ -> None

  let (|LiteralPayloadOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.LiteralPayloadOption as node ->
      Some (node.Value)
    | _ -> None

  let (|SessionTimeoutPayloadOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.SessionTimeoutPayloadOption as node ->
      Some (node.IsNever, node.Timeout)
    | _ -> None

  let (|SchemaPayloadOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.SchemaPayloadOption as node ->
      Some (node.IsStandard)
    | _ -> None

  let (|CharacterSetPayloadOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.CharacterSetPayloadOption as node ->
      Some (node.IsSql)
    | _ -> None

  let (|RolePayloadOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.RolePayloadOption as node ->
      Some (node.Role)
    | _ -> None

  let (|AuthenticationPayloadOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AuthenticationPayloadOption as node ->
      Some (node.Protocol, node.Certificate, node.TryCertificateFirst)
    | _ -> None

  let (|EncryptionPayloadOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.EncryptionPayloadOption as node ->
      Some (node.EncryptionSupport, node.AlgorithmPartOne, node.AlgorithmPartTwo)
    | _ -> None

  let (|SymmetricKey|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.SymmetricKeyStatement as node ->
      Some (node.Name, node.EncryptingMechanisms |> Seq.toList)
    | _ -> None

  let (|CreateSymmetricKey|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.CreateSymmetricKeyStatement as node ->
      Some (node.KeyOptions |> Seq.toList, node.Provider, node.Owner)
    | _ -> None

  let (|KeyOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.KeyOption as node ->
      Some (node.OptionKind)
    | _ -> None

  let (|KeySourceKeyOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.KeySourceKeyOption as node ->
      Some (node.PassPhrase)
    | _ -> None

  let (|AlgorithmKeyOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlgorithmKeyOption as node ->
      Some (node.Algorithm)
    | _ -> None

  let (|IdentityValueKeyOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.IdentityValueKeyOption as node ->
      Some (node.IdentityPhrase)
    | _ -> None

  let (|ProviderKeyNameKeyOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ProviderKeyNameKeyOption as node ->
      Some (node.KeyName)
    | _ -> None

  let (|CreationDispositionKeyOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.CreationDispositionKeyOption as node ->
      Some (node.IsCreateNew)
    | _ -> None

  let (|AlterSymmetricKey|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlterSymmetricKeyStatement as node ->
      Some (node.IsAdd)
    | _ -> None

  let (|FullTextCatalog|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.FullTextCatalogStatement as node ->
      Some (node.Name, node.Options |> Seq.toList)
    | _ -> None

  let (|FullTextCatalogOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.FullTextCatalogOption as node ->
      Some (node.OptionKind)
    | _ -> None

  let (|OnOffFullTextCatalogOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.OnOffFullTextCatalogOption as node ->
      Some (node.OptionState)
    | _ -> None

  let (|CreateFullTextCatalog|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.CreateFullTextCatalogStatement as node ->
      Some (node.FileGroup, node.Path, node.IsDefault, node.Owner)
    | _ -> None

  let (|AlterFullTextCatalog|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlterFullTextCatalogStatement as node ->
      Some (node.Action)
    | _ -> None

  let (|AlterCreateServiceStatementBase|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlterCreateServiceStatementBase as node ->
      Some (node.Name, node.QueueName, node.ServiceContracts |> Seq.toList)
    | _ -> None

  let (|CreateService|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.CreateServiceStatement as node ->
      Some (node.Owner)
    | _ -> None

  let (|ServiceContract|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ServiceContract as node ->
      Some (node.Name, node.Action)
    | _ -> None

  let (|BinaryExpr|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.BinaryExpression as node ->
      Some (node.BinaryExpressionType, node.FirstExpression, node.SecondExpression)
    | _ -> None

  let (|BuiltInFunctionTableRef|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.BuiltInFunctionTableReference as node ->
      Some (node.Name, node.Parameters |> Seq.toList)
    | _ -> None

  let (|GlobalFunctionTableRef|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.GlobalFunctionTableReference as node ->
      Some (node.Name, node.Parameters |> Seq.toList)
    | _ -> None

  let (|ComputeClause|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ComputeClause as node ->
      Some (node.ComputeFunctions |> Seq.toList, node.ByExpressions |> Seq.toList)
    | _ -> None

  let (|ComputeFunction|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ComputeFunction as node ->
      Some (node.ComputeFunctionType, node.Expression)
    | _ -> None

  let (|PivotedTableRef|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.PivotedTableReference as node ->
      Some (node.TableReference, node.InColumns |> Seq.toList, node.PivotColumn, node.ValueColumns |> Seq.toList, node.AggregateFunctionIdentifier)
    | _ -> None

  let (|UnpivotedTableRef|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.UnpivotedTableReference as node ->
      Some (node.TableReference, node.InColumns |> Seq.toList, node.PivotColumn, node.ValueColumn)
    | _ -> None

  let (|JoinTableRef|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.JoinTableReference as node ->
      Some (node.FirstTableReference, node.SecondTableReference)
    | _ -> None

  let (|UnqualifiedJoin|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.UnqualifiedJoin as node ->
      Some (node.UnqualifiedJoinType)
    | _ -> None

  let (|TableSampleClause|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.TableSampleClause as node ->
      Some (node.System, node.SampleNumber, node.TableSampleClauseOption, node.RepeatSeed)
    | _ -> None

  let (|BooleanNotExpr|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.BooleanNotExpression as node ->
      Some (node.Expression)
    | _ -> None

  let (|BooleanParenthesisExpr|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.BooleanParenthesisExpression as node ->
      Some (node.Expression)
    | _ -> None

  let (|BooleanComparisonExpr|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.BooleanComparisonExpression as node ->
      Some (node.ComparisonType, node.FirstExpression, node.SecondExpression)
    | _ -> None

  let (|BooleanBinaryExpr|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.BooleanBinaryExpression as node ->
      Some (node.BinaryExpressionType, node.FirstExpression, node.SecondExpression)
    | _ -> None

  let (|BooleanIsNullExpr|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.BooleanIsNullExpression as node ->
      Some (node.IsNot, node.Expression)
    | _ -> None

  let (|GraphMatchPredicate|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.GraphMatchPredicate as node ->
      Some (node.Expression)
    | _ -> None

  let (|GraphMatchExpr|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.GraphMatchExpression as node ->
      Some (node.LeftNode, node.Edge, node.RightNode, node.ArrowOnRight)
    | _ -> None

  let (|ExpressionWithSortOrder|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ExpressionWithSortOrder as node ->
      Some (node.SortOrder, node.Expression)
    | _ -> None

  let (|GroupByClause|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.GroupByClause as node ->
      Some (node.GroupByOption, node.All, node.GroupingSpecifications |> Seq.toList)
    | _ -> None

  let (|ExpressionGroupingSpecification|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ExpressionGroupingSpecification as node ->
      Some (node.Expression)
    | _ -> None

  let (|CompositeGroupingSpecification|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.CompositeGroupingSpecification as node ->
      Some (node.Items |> Seq.toList)
    | _ -> None

  let (|CubeGroupingSpecification|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.CubeGroupingSpecification as node ->
      Some (node.Arguments |> Seq.toList)
    | _ -> None

  let (|RollupGroupingSpecification|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.RollupGroupingSpecification as node ->
      Some (node.Arguments |> Seq.toList)
    | _ -> None

  let (|GroupingSetsGroupingSpecification|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.GroupingSetsGroupingSpecification as node ->
      Some (node.Sets |> Seq.toList)
    | _ -> None

  let (|OutputClause|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.OutputClause as node ->
      Some (node.SelectColumns |> Seq.toList)
    | _ -> None

  let (|OutputIntoClause|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.OutputIntoClause as node ->
      Some (node.SelectColumns |> Seq.toList, node.IntoTable, node.IntoTableColumns |> Seq.toList)
    | _ -> None

  let (|HavingClause|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.HavingClause as node ->
      Some (node.SearchCondition)
    | _ -> None

  let (|IdentityFunctionCall|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.IdentityFunctionCall as node ->
      Some (node.DataType, node.Seed, node.Increment)
    | _ -> None

  let (|JoinParenthesisTableRef|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.JoinParenthesisTableReference as node ->
      Some (node.Join)
    | _ -> None

  let (|OrderByClause|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.OrderByClause as node ->
      Some (node.OrderByElements |> Seq.toList)
    | _ -> None

  let (|QualifiedJoin|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.QualifiedJoin as node ->
      Some (node.SearchCondition, node.QualifiedJoinType, node.JoinHint)
    | _ -> None

  let (|OdbcQualifiedJoinTableRef|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.OdbcQualifiedJoinTableReference as node ->
      Some (node.TableReference)
    | _ -> None

  let (|QueryExpr|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.QueryExpression as node ->
      Some (node.OrderByClause, node.OffsetClause, node.ForClause)
    | _ -> None

  let (|QueryParenthesisExpr|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.QueryParenthesisExpression as node ->
      Some (node.QueryExpression)
    | _ -> None

  let (|QuerySpecification|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.QuerySpecification as node ->
      Some (node.UniqueRowFilter, node.TopRowFilter, node.SelectElements |> Seq.toList, node.FromClause, node.WhereClause, node.GroupByClause, node.HavingClause)
    | _ -> None

  let (|FromClause|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.FromClause as node ->
      Some (node.TableReferences |> Seq.toList)
    | _ -> None

  let (|SelectScalarExpr|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.SelectScalarExpression as node ->
      Some (node.Expression, node.ColumnName)
    | _ -> None

  let (|SelectStarExpr|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.SelectStarExpression as node ->
      Some (node.Qualifier)
    | _ -> None

  let (|SelectSetVariable|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.SelectSetVariable as node ->
      Some (node.Variable, node.Expression, node.AssignmentKind)
    | _ -> None

  let (|DataModificationTableRef|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.DataModificationTableReference as node ->
      Some (node.DataModificationSpecification)
    | _ -> None

  let (|ChangeTableChangesTableRef|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ChangeTableChangesTableReference as node ->
      Some (node.Target, node.SinceVersion)
    | _ -> None

  let (|ChangeTableVersionTableRef|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ChangeTableVersionTableReference as node ->
      Some (node.Target, node.PrimaryKeyColumns |> Seq.toList, node.PrimaryKeyValues |> Seq.toList)
    | _ -> None

  let (|BooleanTernaryExpr|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.BooleanTernaryExpression as node ->
      Some (node.TernaryExpressionType, node.FirstExpression, node.SecondExpression, node.ThirdExpression)
    | _ -> None

  let (|TopRowFilter|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.TopRowFilter as node ->
      Some (node.Expression, node.Percent, node.WithTies)
    | _ -> None

  let (|OffsetClause|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.OffsetClause as node ->
      Some (node.OffsetExpression, node.FetchExpression)
    | _ -> None

  let (|UnaryExpr|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.UnaryExpression as node ->
      Some (node.UnaryExpressionType, node.Expression)
    | _ -> None

  let (|BinaryQueryExpr|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.BinaryQueryExpression as node ->
      Some (node.BinaryQueryExpressionType, node.All, node.FirstQueryExpression, node.SecondQueryExpression)
    | _ -> None

  let (|VariableTableRef|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.VariableTableReference as node ->
      Some (node.Variable)
    | _ -> None

  let (|VariableMethodCallTableRef|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.VariableMethodCallTableReference as node ->
      Some (node.Variable, node.MethodName, node.Parameters |> Seq.toList)
    | _ -> None

  let (|DropAssembly|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.DropAssemblyStatement as node ->
      Some (node.WithNoDependents)
    | _ -> None

  let (|DropFullTextIndex|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.DropFullTextIndexStatement as node ->
      Some (node.TableName)
    | _ -> None

  let (|DropType|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.DropTypeStatement as node ->
      Some (node.Name, node.IsIfExists)
    | _ -> None

  let (|DropSymmetricKey|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.DropSymmetricKeyStatement as node ->
      Some (node.RemoveProviderKey)
    | _ -> None

  let (|DropAsymmetricKey|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.DropAsymmetricKeyStatement as node ->
      Some (node.RemoveProviderKey)
    | _ -> None

  let (|DropCredential|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.DropCredentialStatement as node ->
      Some (node.IsDatabaseScoped)
    | _ -> None

  let (|AlterPartitionFunction|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlterPartitionFunctionStatement as node ->
      Some (node.Name, node.IsSplit, node.Boundary)
    | _ -> None

  let (|AlterPartitionScheme|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlterPartitionSchemeStatement as node ->
      Some (node.Name, node.FileGroup)
    | _ -> None

  let (|AlterFullTextIndex|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlterFullTextIndexStatement as node ->
      Some (node.OnName, node.Action)
    | _ -> None

  let (|SimpleAlterFullTextIndexAction|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.SimpleAlterFullTextIndexAction as node ->
      Some (node.ActionKind)
    | _ -> None

  let (|SetStopListAlterFullTextIndexAction|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.SetStopListAlterFullTextIndexAction as node ->
      Some (node.StopListOption, node.WithNoPopulation)
    | _ -> None

  let (|SetSearchPropertyListAlterFullTextIndexAction|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.SetSearchPropertyListAlterFullTextIndexAction as node ->
      Some (node.SearchPropertyListOption, node.WithNoPopulation)
    | _ -> None

  let (|DropAlterFullTextIndexAction|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.DropAlterFullTextIndexAction as node ->
      Some (node.Columns |> Seq.toList, node.WithNoPopulation)
    | _ -> None

  let (|AddAlterFullTextIndexAction|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AddAlterFullTextIndexAction as node ->
      Some (node.Columns |> Seq.toList, node.WithNoPopulation)
    | _ -> None

  let (|AlterColumnAlterFullTextIndexAction|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlterColumnAlterFullTextIndexAction as node ->
      Some (node.Column, node.WithNoPopulation)
    | _ -> None

  let (|CreateSearchPropertyList|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.CreateSearchPropertyListStatement as node ->
      Some (node.Name, node.SourceSearchPropertyList, node.Owner)
    | _ -> None

  let (|AlterSearchPropertyList|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlterSearchPropertyListStatement as node ->
      Some (node.Name, node.Action)
    | _ -> None

  let (|AddSearchPropertyListAction|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AddSearchPropertyListAction as node ->
      Some (node.PropertyName, node.Guid, node.Id, node.Description)
    | _ -> None

  let (|DropSearchPropertyListAction|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.DropSearchPropertyListAction as node ->
      Some (node.PropertyName)
    | _ -> None

  let (|CreateLogin|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.CreateLoginStatement as node ->
      Some (node.Name, node.Source)
    | _ -> None

  let (|PasswordCreateLoginSource|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.PasswordCreateLoginSource as node ->
      Some (node.Password, node.Hashed, node.MustChange, node.Options |> Seq.toList)
    | _ -> None

  let (|PrincipalOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.PrincipalOption as node ->
      Some (node.OptionKind)
    | _ -> None

  let (|OnOffPrincipalOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.OnOffPrincipalOption as node ->
      Some (node.OptionState)
    | _ -> None

  let (|LiteralPrincipalOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.LiteralPrincipalOption as node ->
      Some (node.Value)
    | _ -> None

  let (|IdentifierPrincipalOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.IdentifierPrincipalOption as node ->
      Some (node.Identifier)
    | _ -> None

  let (|WindowsCreateLoginSource|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.WindowsCreateLoginSource as node ->
      Some (node.Options |> Seq.toList)
    | _ -> None

  let (|CertificateCreateLoginSource|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.CertificateCreateLoginSource as node ->
      Some (node.Certificate, node.Credential)
    | _ -> None

  let (|AsymmetricKeyCreateLoginSource|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AsymmetricKeyCreateLoginSource as node ->
      Some (node.Key, node.Credential)
    | _ -> None

  let (|PasswordAlterPrincipalOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.PasswordAlterPrincipalOption as node ->
      Some (node.Password, node.OldPassword, node.MustChange, node.Unlock, node.Hashed)
    | _ -> None

  let (|AlterLogin|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlterLoginStatement as node ->
      Some (node.Name)
    | _ -> None

  let (|AlterLoginOptions|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlterLoginOptionsStatement as node ->
      Some (node.Options |> Seq.toList)
    | _ -> None

  let (|AlterLoginEnableDisable|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlterLoginEnableDisableStatement as node ->
      Some (node.IsEnable)
    | _ -> None

  let (|AlterLoginAddDropCredential|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlterLoginAddDropCredentialStatement as node ->
      Some (node.IsAdd, node.CredentialName)
    | _ -> None

  let (|Revert|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.RevertStatement as node ->
      Some (node.Cookie)
    | _ -> None

  let (|DropQueue|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.DropQueueStatement as node ->
      Some (node.Name)
    | _ -> None

  let (|SignatureStatementBase|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.SignatureStatementBase as node ->
      Some (node.IsCounter, node.ElementKind, node.Element, node.Cryptos |> Seq.toList)
    | _ -> None

  let (|DropEventNotification|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.DropEventNotificationStatement as node ->
      Some (node.Notifications |> Seq.toList, node.Scope)
    | _ -> None

  let (|ExecuteAs|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ExecuteAsStatement as node ->
      Some (node.WithNoRevert, node.Cookie, node.ExecuteContext)
    | _ -> None

  let (|EndConversation|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.EndConversationStatement as node ->
      Some (node.Conversation, node.WithCleanup, node.ErrorCode, node.ErrorDescription)
    | _ -> None

  let (|MoveConversation|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.MoveConversationStatement as node ->
      Some (node.Conversation, node.Group)
    | _ -> None

  let (|GetConversationGroup|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.GetConversationGroupStatement as node ->
      Some (node.GroupId, node.Queue)
    | _ -> None

  let (|Receive|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ReceiveStatement as node ->
      Some (node.Top, node.SelectElements |> Seq.toList, node.Queue, node.Into, node.Where, node.IsConversationGroupIdWhere)
    | _ -> None

  let (|Send|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.SendStatement as node ->
      Some (node.ConversationHandles |> Seq.toList, node.MessageTypeName, node.MessageBody)
    | _ -> None

  let (|AlterSchema|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlterSchemaStatement as node ->
      Some (node.Name, node.ObjectName, node.ObjectKind)
    | _ -> None

  let (|AlterAsymmetricKey|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlterAsymmetricKeyStatement as node ->
      Some (node.Name, node.AttestedBy, node.Kind, node.EncryptionPassword, node.DecryptionPassword)
    | _ -> None

  let (|AlterServiceMasterKey|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlterServiceMasterKeyStatement as node ->
      Some (node.Account, node.Password, node.Kind)
    | _ -> None

  let (|BeginConversationTimer|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.BeginConversationTimerStatement as node ->
      Some (node.Handle, node.Timeout)
    | _ -> None

  let (|BeginDialog|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.BeginDialogStatement as node ->
      Some (node.IsConversation, node.Handle, node.InitiatorServiceName, node.TargetServiceName, node.InstanceSpec, node.ContractName, node.Options |> Seq.toList)
    | _ -> None

  let (|DialogOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.DialogOption as node ->
      Some (node.OptionKind)
    | _ -> None

  let (|ScalarExpressionDialogOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ScalarExpressionDialogOption as node ->
      Some (node.Value)
    | _ -> None

  let (|OnOffDialogOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.OnOffDialogOption as node ->
      Some (node.OptionState)
    | _ -> None

  let (|BackupCertificate|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.BackupCertificateStatement as node ->
      Some (node.File)
    | _ -> None

  let (|BackupRestoreMasterKeyStatementBase|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.BackupRestoreMasterKeyStatementBase as node ->
      Some (node.File, node.Password)
    | _ -> None

  let (|RestoreServiceMasterKey|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.RestoreServiceMasterKeyStatement as node ->
      Some (node.IsForce)
    | _ -> None

  let (|RestoreMasterKey|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.RestoreMasterKeyStatement as node ->
      Some (node.IsForce, node.EncryptionPassword)
    | _ -> None

  let (|ScalarExpressionSnippet|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ScalarExpressionSnippet as node ->
      Some (node.Script)
    | _ -> None

  let (|BooleanExpressionSnippet|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.BooleanExpressionSnippet as node ->
      Some (node.Script)
    | _ -> None

  let (|StatementListSnippet|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.StatementListSnippet as node ->
      Some (node.Script)
    | _ -> None

  let (|SelectStatementSnippet|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.SelectStatementSnippet as node ->
      Some (node.Script)
    | _ -> None

  let (|SchemaObjectNameSnippet|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.SchemaObjectNameSnippet as node ->
      Some (node.Script)
    | _ -> None

  let (|TSqlFragmentSnippet|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragmentSnippet as node ->
      Some (node.Script)
    | _ -> None

  let (|TSqlStatementSnippet|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.TSqlStatementSnippet as node ->
      Some (node.Script)
    | _ -> None

  let (|IdentifierSnippet|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.IdentifierSnippet as node ->
      Some (node.Script)
    | _ -> None

  let (|TSqlScript|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.TSqlScript as node ->
      Some (node.Batches |> Seq.toList)
    | _ -> None

  let (|TSqlBatch|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.TSqlBatch as node ->
      Some (node.Statements |> Seq.toList)
    | _ -> None

  let (|Merge|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.MergeStatement as node ->
      Some (node.MergeSpecification)
    | _ -> None

  let (|MergeSpecification|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.MergeSpecification as node ->
      Some (node.TableAlias, node.TableReference, node.SearchCondition, node.ActionClauses |> Seq.toList)
    | _ -> None

  let (|MergeActionClause|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.MergeActionClause as node ->
      Some (node.Condition, node.SearchCondition, node.Action)
    | _ -> None

  let (|UpdateMergeAction|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.UpdateMergeAction as node ->
      Some (node.SetClauses |> Seq.toList)
    | _ -> None

  let (|InsertMergeAction|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.InsertMergeAction as node ->
      Some (node.Columns |> Seq.toList, node.Source)
    | _ -> None

  let (|CreateTypeTable|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.CreateTypeTableStatement as node ->
      Some (node.Definition, node.Options |> Seq.toList)
    | _ -> None

  let (|AuditSpecification|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AuditSpecificationStatement as node ->
      Some (node.AuditState, node.Parts |> Seq.toList, node.SpecificationName, node.AuditName)
    | _ -> None

  let (|AuditSpecificationPart|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AuditSpecificationPart as node ->
      Some (node.IsDrop, node.Details)
    | _ -> None

  let (|AuditActionSpecification|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AuditActionSpecification as node ->
      Some (node.Actions |> Seq.toList, node.Principals |> Seq.toList, node.TargetObject)
    | _ -> None

  let (|DatabaseAuditAction|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.DatabaseAuditAction as node ->
      Some (node.ActionKind)
    | _ -> None

  let (|AuditActionGroupRef|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AuditActionGroupReference as node ->
      Some (node.Group)
    | _ -> None

  let (|ServerAudit|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ServerAuditStatement as node ->
      Some (node.AuditName, node.AuditTarget, node.Options |> Seq.toList, node.PredicateExpression)
    | _ -> None

  let (|AlterServerAudit|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlterServerAuditStatement as node ->
      Some (node.NewName, node.RemoveWhere)
    | _ -> None

  let (|AuditTarget|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AuditTarget as node ->
      Some (node.TargetKind, node.TargetOptions |> Seq.toList)
    | _ -> None

  let (|AuditOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AuditOption as node ->
      Some (node.OptionKind)
    | _ -> None

  let (|QueueDelayAuditOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.QueueDelayAuditOption as node ->
      Some (node.Delay)
    | _ -> None

  let (|AuditGuidAuditOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AuditGuidAuditOption as node ->
      Some (node.Guid)
    | _ -> None

  let (|OnFailureAuditOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.OnFailureAuditOption as node ->
      Some (node.OnFailureAction)
    | _ -> None

  let (|StateAuditOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.StateAuditOption as node ->
      Some (node.Value)
    | _ -> None

  let (|AuditTargetOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AuditTargetOption as node ->
      Some (node.OptionKind)
    | _ -> None

  let (|MaxSizeAuditTargetOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.MaxSizeAuditTargetOption as node ->
      Some (node.IsUnlimited, node.Size, node.Unit)
    | _ -> None

  let (|MaxRolloverFilesAuditTargetOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.MaxRolloverFilesAuditTargetOption as node ->
      Some (node.Value, node.IsUnlimited)
    | _ -> None

  let (|LiteralAuditTargetOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.LiteralAuditTargetOption as node ->
      Some (node.Value)
    | _ -> None

  let (|OnOffAuditTargetOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.OnOffAuditTargetOption as node ->
      Some (node.Value)
    | _ -> None

  let (|DatabaseEncryptionKey|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.DatabaseEncryptionKeyStatement as node ->
      Some (node.Encryptor, node.Algorithm)
    | _ -> None

  let (|AlterDatabaseEncryptionKey|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlterDatabaseEncryptionKeyStatement as node ->
      Some (node.Regenerate)
    | _ -> None

  let (|ResourcePool|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ResourcePoolStatement as node ->
      Some (node.Name, node.ResourcePoolParameters |> Seq.toList)
    | _ -> None

  let (|ResourcePoolParameter|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ResourcePoolParameter as node ->
      Some (node.ParameterType, node.ParameterValue, node.AffinitySpecification)
    | _ -> None

  let (|ResourcePoolAffinitySpecification|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ResourcePoolAffinitySpecification as node ->
      Some (node.AffinityType, node.ParameterValue, node.IsAuto, node.PoolAffinityRanges |> Seq.toList)
    | _ -> None

  let (|ExternalResourcePool|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ExternalResourcePoolStatement as node ->
      Some (node.Name, node.ExternalResourcePoolParameters |> Seq.toList)
    | _ -> None

  let (|ExternalResourcePoolParameter|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ExternalResourcePoolParameter as node ->
      Some (node.ParameterType, node.ParameterValue, node.AffinitySpecification)
    | _ -> None

  let (|ExternalResourcePoolAffinitySpecification|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.ExternalResourcePoolAffinitySpecification as node ->
      Some (node.AffinityType, node.ParameterValue, node.IsAuto, node.PoolAffinityRanges |> Seq.toList)
    | _ -> None

  let (|WorkloadGroup|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.WorkloadGroupStatement as node ->
      Some (node.Name, node.WorkloadGroupParameters |> Seq.toList, node.PoolName, node.ExternalPoolName)
    | _ -> None

  let (|WorkloadGroupParameter|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.WorkloadGroupParameter as node ->
      Some (node.ParameterType)
    | _ -> None

  let (|WorkloadGroupResourceParameter|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.WorkloadGroupResourceParameter as node ->
      Some (node.ParameterValue)
    | _ -> None

  let (|WorkloadGroupImportanceParameter|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.WorkloadGroupImportanceParameter as node ->
      Some (node.ParameterValue)
    | _ -> None

  let (|BrokerPriority|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.BrokerPriorityStatement as node ->
      Some (node.Name, node.BrokerPriorityParameters |> Seq.toList)
    | _ -> None

  let (|BrokerPriorityParameter|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.BrokerPriorityParameter as node ->
      Some (node.IsDefaultOrAny, node.ParameterType, node.ParameterValue)
    | _ -> None

  let (|CreateFullTextStopList|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.CreateFullTextStopListStatement as node ->
      Some (node.Name, node.IsSystemStopList, node.DatabaseName, node.SourceStopListName, node.Owner)
    | _ -> None

  let (|AlterFullTextStopList|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlterFullTextStopListStatement as node ->
      Some (node.Name, node.Action)
    | _ -> None

  let (|FullTextStopListAction|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.FullTextStopListAction as node ->
      Some (node.IsAdd, node.IsAll, node.StopWord, node.LanguageTerm)
    | _ -> None

  let (|CreateCryptographicProvider|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.CreateCryptographicProviderStatement as node ->
      Some (node.Name, node.File)
    | _ -> None

  let (|AlterCryptographicProvider|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlterCryptographicProviderStatement as node ->
      Some (node.Name, node.Option, node.File)
    | _ -> None

  let (|EventSessionObjectName|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.EventSessionObjectName as node ->
      Some (node.MultiPartIdentifier)
    | _ -> None

  let (|EventSession|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.EventSessionStatement as node ->
      Some (node.Name, node.SessionScope, node.EventDeclarations |> Seq.toList, node.TargetDeclarations |> Seq.toList, node.SessionOptions |> Seq.toList)
    | _ -> None

  let (|EventDeclaration|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.EventDeclaration as node ->
      Some (node.ObjectName, node.EventDeclarationSetParameters |> Seq.toList, node.EventDeclarationActionParameters |> Seq.toList, node.EventDeclarationPredicateParameter)
    | _ -> None

  let (|EventDeclarationSetParameter|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.EventDeclarationSetParameter as node ->
      Some (node.EventField, node.EventValue)
    | _ -> None

  let (|SourceDeclaration|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.SourceDeclaration as node ->
      Some (node.Value)
    | _ -> None

  let (|EventDeclarationCompareFunctionParameter|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.EventDeclarationCompareFunctionParameter as node ->
      Some (node.Name, node.SourceDeclaration, node.EventValue)
    | _ -> None

  let (|TargetDeclaration|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.TargetDeclaration as node ->
      Some (node.ObjectName, node.TargetDeclarationParameters |> Seq.toList)
    | _ -> None

  let (|SessionOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.SessionOption as node ->
      Some (node.OptionKind)
    | _ -> None

  let (|EventRetentionSessionOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.EventRetentionSessionOption as node ->
      Some (node.Value)
    | _ -> None

  let (|MemoryPartitionSessionOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.MemoryPartitionSessionOption as node ->
      Some (node.Value)
    | _ -> None

  let (|LiteralSessionOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.LiteralSessionOption as node ->
      Some (node.Value, node.Unit)
    | _ -> None

  let (|MaxDispatchLatencySessionOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.MaxDispatchLatencySessionOption as node ->
      Some (node.IsInfinite, node.Value)
    | _ -> None

  let (|OnOffSessionOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.OnOffSessionOption as node ->
      Some (node.OptionState)
    | _ -> None

  let (|AlterEventSession|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlterEventSessionStatement as node ->
      Some (node.StatementType, node.DropEventDeclarations |> Seq.toList, node.DropTargetDeclarations |> Seq.toList)
    | _ -> None

  let (|DropEventSession|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.DropEventSessionStatement as node ->
      Some (node.SessionScope)
    | _ -> None

  let (|AlterResourceGovernor|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlterResourceGovernorStatement as node ->
      Some (node.Command, node.ClassifierFunction)
    | _ -> None

  let (|CreateSpatialIndex|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.CreateSpatialIndexStatement as node ->
      Some (node.Name, node.Object, node.SpatialColumnName, node.SpatialIndexingScheme, node.SpatialIndexOptions |> Seq.toList, node.OnFileGroup)
    | _ -> None

  let (|SpatialIndexRegularOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.SpatialIndexRegularOption as node ->
      Some (node.Option)
    | _ -> None

  let (|BoundingBoxSpatialIndexOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.BoundingBoxSpatialIndexOption as node ->
      Some (node.BoundingBoxParameters |> Seq.toList)
    | _ -> None

  let (|BoundingBoxParameter|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.BoundingBoxParameter as node ->
      Some (node.Parameter, node.Value)
    | _ -> None

  let (|GridsSpatialIndexOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.GridsSpatialIndexOption as node ->
      Some (node.GridParameters |> Seq.toList)
    | _ -> None

  let (|GridParameter|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.GridParameter as node ->
      Some (node.Parameter, node.Value)
    | _ -> None

  let (|CellsPerObjectSpatialIndexOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.CellsPerObjectSpatialIndexOption as node ->
      Some (node.Value)
    | _ -> None

  let (|AlterServerConfiguration|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlterServerConfigurationStatement as node ->
      Some (node.ProcessAffinity, node.ProcessAffinityRanges |> Seq.toList)
    | _ -> None

  let (|AlterServerConfigurationSetBufferPoolExtension|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlterServerConfigurationSetBufferPoolExtensionStatement as node ->
      Some (node.Options |> Seq.toList)
    | _ -> None

  let (|AlterServerConfigurationBufferPoolExtensionOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlterServerConfigurationBufferPoolExtensionOption as node ->
      Some (node.OptionKind, node.OptionValue)
    | _ -> None

  let (|AlterServerConfigurationBufferPoolExtensionContainerOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlterServerConfigurationBufferPoolExtensionContainerOption as node ->
      Some (node.Suboptions |> Seq.toList)
    | _ -> None

  let (|AlterServerConfigurationBufferPoolExtensionSizeOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlterServerConfigurationBufferPoolExtensionSizeOption as node ->
      Some (node.SizeUnit)
    | _ -> None

  let (|AlterServerConfigurationSetDiagnosticsLog|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlterServerConfigurationSetDiagnosticsLogStatement as node ->
      Some (node.Options |> Seq.toList)
    | _ -> None

  let (|AlterServerConfigurationDiagnosticsLogOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlterServerConfigurationDiagnosticsLogOption as node ->
      Some (node.OptionKind, node.OptionValue)
    | _ -> None

  let (|AlterServerConfigurationDiagnosticsLogMaxSizeOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlterServerConfigurationDiagnosticsLogMaxSizeOption as node ->
      Some (node.SizeUnit)
    | _ -> None

  let (|AlterServerConfigurationSetFailoverClusterProperty|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlterServerConfigurationSetFailoverClusterPropertyStatement as node ->
      Some (node.Options |> Seq.toList)
    | _ -> None

  let (|AlterServerConfigurationFailoverClusterPropertyOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlterServerConfigurationFailoverClusterPropertyOption as node ->
      Some (node.OptionKind, node.OptionValue)
    | _ -> None

  let (|AlterServerConfigurationSetHadrCluster|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlterServerConfigurationSetHadrClusterStatement as node ->
      Some (node.Options |> Seq.toList)
    | _ -> None

  let (|AlterServerConfigurationHadrClusterOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlterServerConfigurationHadrClusterOption as node ->
      Some (node.OptionKind, node.OptionValue, node.IsLocal)
    | _ -> None

  let (|AlterServerConfigurationSetSoftNuma|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlterServerConfigurationSetSoftNumaStatement as node ->
      Some (node.Options |> Seq.toList)
    | _ -> None

  let (|AlterServerConfigurationSoftNumaOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlterServerConfigurationSoftNumaOption as node ->
      Some (node.OptionKind, node.OptionValue)
    | _ -> None

  let (|AvailabilityGroup|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AvailabilityGroupStatement as node ->
      Some (node.Name, node.Options |> Seq.toList, node.Databases |> Seq.toList, node.Replicas |> Seq.toList)
    | _ -> None

  let (|AlterAvailabilityGroup|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlterAvailabilityGroupStatement as node ->
      Some (node.AlterAvailabilityGroupStatementType, node.Action)
    | _ -> None

  let (|AvailabilityReplica|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AvailabilityReplica as node ->
      Some (node.ServerName, node.Options |> Seq.toList)
    | _ -> None

  let (|AvailabilityReplicaOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AvailabilityReplicaOption as node ->
      Some (node.OptionKind)
    | _ -> None

  let (|LiteralReplicaOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.LiteralReplicaOption as node ->
      Some (node.Value)
    | _ -> None

  let (|AvailabilityModeReplicaOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AvailabilityModeReplicaOption as node ->
      Some (node.Value)
    | _ -> None

  let (|FailoverModeReplicaOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.FailoverModeReplicaOption as node ->
      Some (node.Value)
    | _ -> None

  let (|PrimaryRoleReplicaOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.PrimaryRoleReplicaOption as node ->
      Some (node.AllowConnections)
    | _ -> None

  let (|SecondaryRoleReplicaOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.SecondaryRoleReplicaOption as node ->
      Some (node.AllowConnections)
    | _ -> None

  let (|AvailabilityGroupOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AvailabilityGroupOption as node ->
      Some (node.OptionKind)
    | _ -> None

  let (|LiteralAvailabilityGroupOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.LiteralAvailabilityGroupOption as node ->
      Some (node.Value)
    | _ -> None

  let (|AlterAvailabilityGroupAction|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlterAvailabilityGroupAction as node ->
      Some (node.ActionType)
    | _ -> None

  let (|AlterAvailabilityGroupFailoverAction|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlterAvailabilityGroupFailoverAction as node ->
      Some (node.Options |> Seq.toList)
    | _ -> None

  let (|AlterAvailabilityGroupFailoverOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlterAvailabilityGroupFailoverOption as node ->
      Some (node.OptionKind, node.Value)
    | _ -> None

  let (|CreateFederation|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.CreateFederationStatement as node ->
      Some (node.Name, node.DistributionName, node.DataType)
    | _ -> None

  let (|AlterFederation|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.AlterFederationStatement as node ->
      Some (node.Name, node.Kind, node.DistributionName, node.Boundary)
    | _ -> None

  let (|UseFederation|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.UseFederationStatement as node ->
      Some (node.FederationName, node.DistributionName, node.Value, node.Filtering)
    | _ -> None

  let (|Disk|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.DiskStatement as node ->
      Some (node.DiskStatementType, node.Options |> Seq.toList)
    | _ -> None

  let (|DiskStatementOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.DiskStatementOption as node ->
      Some (node.OptionKind, node.Value)
    | _ -> None

  let (|CreateColumnStoreIndex|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.CreateColumnStoreIndexStatement as node ->
      Some (node.Name, (if node.Clustered.HasValue then Some node.Clustered.Value else None), node.OnName, node.Columns |> Seq.toList, node.FilterPredicate, node.IndexOptions |> Seq.toList, node.OnFileGroupOrPartitionScheme)
    | _ -> None

  let (|WindowFrameClause|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.WindowFrameClause as node ->
      Some (node.Top, node.Bottom, node.WindowFrameType)
    | _ -> None

  let (|WindowDelimiter|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.WindowDelimiter as node ->
      Some (node.WindowDelimiterType, node.OffsetValue)
    | _ -> None

  let (|WithinGroupClause|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.WithinGroupClause as node ->
      Some (node.OrderByClause)
    | _ -> None

  let (|SelectiveXmlIndexPromotedPath|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.SelectiveXmlIndexPromotedPath as node ->
      Some (node.Name, node.Path, node.SQLDataType, node.XQueryDataType, node.MaxLength, node.IsSingleton)
    | _ -> None

  let (|TemporalClause|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.TemporalClause as node ->
      Some (node.TemporalClauseType, node.StartTime, node.EndTime)
    | _ -> None

  let (|CompressionDelayIndexOpt|_|) (node:Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragment) =
    match node with
    | :? Microsoft.SqlServer.TransactSql.ScriptDom.CompressionDelayIndexOption as node ->
      Some (node.Expression, node.TimeUnit)
    | _ -> None

