//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from c:\Users\della\projects\the-interpreter-101\Lang.g4 by ANTLR 4.9.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Grammar {

using Antlr4.Runtime.Misc;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="ILangListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.2")]
[System.Diagnostics.DebuggerNonUserCode]
[System.CLSCompliant(false)]
public partial class LangBaseListener : ILangListener {
	/// <summary>
	/// Enter a parse tree produced by the <c>progLine</c>
	/// labeled alternative in <see cref="LangParser.prog"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterProgLine([NotNull] LangParser.ProgLineContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>progLine</c>
	/// labeled alternative in <see cref="LangParser.prog"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitProgLine([NotNull] LangParser.ProgLineContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="LangParser.functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunctions([NotNull] LangParser.FunctionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="LangParser.functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunctions([NotNull] LangParser.FunctionsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="LangParser.function"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunction([NotNull] LangParser.FunctionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="LangParser.function"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunction([NotNull] LangParser.FunctionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>fnBlockLine</c>
	/// labeled alternative in <see cref="LangParser.fnBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFnBlockLine([NotNull] LangParser.FnBlockLineContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>fnBlockLine</c>
	/// labeled alternative in <see cref="LangParser.fnBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFnBlockLine([NotNull] LangParser.FnBlockLineContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>fnBodyLine</c>
	/// labeled alternative in <see cref="LangParser.fnBody"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFnBodyLine([NotNull] LangParser.FnBodyLineContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>fnBodyLine</c>
	/// labeled alternative in <see cref="LangParser.fnBody"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFnBodyLine([NotNull] LangParser.FnBodyLineContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>fnBodyLineMore</c>
	/// labeled alternative in <see cref="LangParser.fnBody"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFnBodyLineMore([NotNull] LangParser.FnBodyLineMoreContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>fnBodyLineMore</c>
	/// labeled alternative in <see cref="LangParser.fnBody"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFnBodyLineMore([NotNull] LangParser.FnBodyLineMoreContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>fnReturnExprLine</c>
	/// labeled alternative in <see cref="LangParser.fnBody"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFnReturnExprLine([NotNull] LangParser.FnReturnExprLineContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>fnReturnExprLine</c>
	/// labeled alternative in <see cref="LangParser.fnBody"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFnReturnExprLine([NotNull] LangParser.FnReturnExprLineContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>fnReturnLine</c>
	/// labeled alternative in <see cref="LangParser.fnBody"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFnReturnLine([NotNull] LangParser.FnReturnLineContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>fnReturnLine</c>
	/// labeled alternative in <see cref="LangParser.fnBody"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFnReturnLine([NotNull] LangParser.FnReturnLineContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="LangParser.params"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParams([NotNull] LangParser.ParamsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="LangParser.params"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParams([NotNull] LangParser.ParamsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>lineStmt</c>
	/// labeled alternative in <see cref="LangParser.line"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLineStmt([NotNull] LangParser.LineStmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>lineStmt</c>
	/// labeled alternative in <see cref="LangParser.line"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLineStmt([NotNull] LangParser.LineStmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>lineIf</c>
	/// labeled alternative in <see cref="LangParser.line"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLineIf([NotNull] LangParser.LineIfContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>lineIf</c>
	/// labeled alternative in <see cref="LangParser.line"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLineIf([NotNull] LangParser.LineIfContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>lineFuncInvoc</c>
	/// labeled alternative in <see cref="LangParser.line"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLineFuncInvoc([NotNull] LangParser.LineFuncInvocContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>lineFuncInvoc</c>
	/// labeled alternative in <see cref="LangParser.line"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLineFuncInvoc([NotNull] LangParser.LineFuncInvocContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>lineEOL</c>
	/// labeled alternative in <see cref="LangParser.line"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLineEOL([NotNull] LangParser.LineEOLContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>lineEOL</c>
	/// labeled alternative in <see cref="LangParser.line"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLineEOL([NotNull] LangParser.LineEOLContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>funcInvocLine</c>
	/// labeled alternative in <see cref="LangParser.funcInvoc"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFuncInvocLine([NotNull] LangParser.FuncInvocLineContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>funcInvocLine</c>
	/// labeled alternative in <see cref="LangParser.funcInvoc"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFuncInvocLine([NotNull] LangParser.FuncInvocLineContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>stmtAtrib</c>
	/// labeled alternative in <see cref="LangParser.stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStmtAtrib([NotNull] LangParser.StmtAtribContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>stmtAtrib</c>
	/// labeled alternative in <see cref="LangParser.stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStmtAtrib([NotNull] LangParser.StmtAtribContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>stmtInput</c>
	/// labeled alternative in <see cref="LangParser.stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStmtInput([NotNull] LangParser.StmtInputContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>stmtInput</c>
	/// labeled alternative in <see cref="LangParser.stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStmtInput([NotNull] LangParser.StmtInputContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>stmtOutput</c>
	/// labeled alternative in <see cref="LangParser.stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStmtOutput([NotNull] LangParser.StmtOutputContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>stmtOutput</c>
	/// labeled alternative in <see cref="LangParser.stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStmtOutput([NotNull] LangParser.StmtOutputContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>inputRead</c>
	/// labeled alternative in <see cref="LangParser.input"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInputRead([NotNull] LangParser.InputReadContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>inputRead</c>
	/// labeled alternative in <see cref="LangParser.input"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInputRead([NotNull] LangParser.InputReadContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>outputWriteVar</c>
	/// labeled alternative in <see cref="LangParser.output"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOutputWriteVar([NotNull] LangParser.OutputWriteVarContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>outputWriteVar</c>
	/// labeled alternative in <see cref="LangParser.output"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOutputWriteVar([NotNull] LangParser.OutputWriteVarContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>outputWriteStr</c>
	/// labeled alternative in <see cref="LangParser.output"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOutputWriteStr([NotNull] LangParser.OutputWriteStrContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>outputWriteStr</c>
	/// labeled alternative in <see cref="LangParser.output"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOutputWriteStr([NotNull] LangParser.OutputWriteStrContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>outputWriteExpr</c>
	/// labeled alternative in <see cref="LangParser.output"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOutputWriteExpr([NotNull] LangParser.OutputWriteExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>outputWriteExpr</c>
	/// labeled alternative in <see cref="LangParser.output"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOutputWriteExpr([NotNull] LangParser.OutputWriteExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>ifstIf</c>
	/// labeled alternative in <see cref="LangParser.ifst"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIfstIf([NotNull] LangParser.IfstIfContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ifstIf</c>
	/// labeled alternative in <see cref="LangParser.ifst"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIfstIf([NotNull] LangParser.IfstIfContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>ifstIfElse</c>
	/// labeled alternative in <see cref="LangParser.ifst"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIfstIfElse([NotNull] LangParser.IfstIfElseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ifstIfElse</c>
	/// labeled alternative in <see cref="LangParser.ifst"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIfstIfElse([NotNull] LangParser.IfstIfElseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>blockLine</c>
	/// labeled alternative in <see cref="LangParser.block"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBlockLine([NotNull] LangParser.BlockLineContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>blockLine</c>
	/// labeled alternative in <see cref="LangParser.block"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBlockLine([NotNull] LangParser.BlockLineContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>condRelop</c>
	/// labeled alternative in <see cref="LangParser.cond"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCondRelop([NotNull] LangParser.CondRelopContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>condRelop</c>
	/// labeled alternative in <see cref="LangParser.cond"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCondRelop([NotNull] LangParser.CondRelopContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>condExpr</c>
	/// labeled alternative in <see cref="LangParser.cond"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCondExpr([NotNull] LangParser.CondExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>condExpr</c>
	/// labeled alternative in <see cref="LangParser.cond"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCondExpr([NotNull] LangParser.CondExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>condAnd</c>
	/// labeled alternative in <see cref="LangParser.cond"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCondAnd([NotNull] LangParser.CondAndContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>condAnd</c>
	/// labeled alternative in <see cref="LangParser.cond"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCondAnd([NotNull] LangParser.CondAndContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>condOr</c>
	/// labeled alternative in <see cref="LangParser.cond"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCondOr([NotNull] LangParser.CondOrContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>condOr</c>
	/// labeled alternative in <see cref="LangParser.cond"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCondOr([NotNull] LangParser.CondOrContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>condNot</c>
	/// labeled alternative in <see cref="LangParser.cond"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCondNot([NotNull] LangParser.CondNotContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>condNot</c>
	/// labeled alternative in <see cref="LangParser.cond"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCondNot([NotNull] LangParser.CondNotContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>atribVar</c>
	/// labeled alternative in <see cref="LangParser.atrib"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAtribVar([NotNull] LangParser.AtribVarContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>atribVar</c>
	/// labeled alternative in <see cref="LangParser.atrib"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAtribVar([NotNull] LangParser.AtribVarContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>exprPlus</c>
	/// labeled alternative in <see cref="LangParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExprPlus([NotNull] LangParser.ExprPlusContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>exprPlus</c>
	/// labeled alternative in <see cref="LangParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExprPlus([NotNull] LangParser.ExprPlusContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>exprMinus</c>
	/// labeled alternative in <see cref="LangParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExprMinus([NotNull] LangParser.ExprMinusContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>exprMinus</c>
	/// labeled alternative in <see cref="LangParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExprMinus([NotNull] LangParser.ExprMinusContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>exprTerm</c>
	/// labeled alternative in <see cref="LangParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExprTerm([NotNull] LangParser.ExprTermContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>exprTerm</c>
	/// labeled alternative in <see cref="LangParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExprTerm([NotNull] LangParser.ExprTermContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>termMult</c>
	/// labeled alternative in <see cref="LangParser.term"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTermMult([NotNull] LangParser.TermMultContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>termMult</c>
	/// labeled alternative in <see cref="LangParser.term"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTermMult([NotNull] LangParser.TermMultContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>termDiv</c>
	/// labeled alternative in <see cref="LangParser.term"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTermDiv([NotNull] LangParser.TermDivContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>termDiv</c>
	/// labeled alternative in <see cref="LangParser.term"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTermDiv([NotNull] LangParser.TermDivContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>termFactor</c>
	/// labeled alternative in <see cref="LangParser.term"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTermFactor([NotNull] LangParser.TermFactorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>termFactor</c>
	/// labeled alternative in <see cref="LangParser.term"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTermFactor([NotNull] LangParser.TermFactorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>factorExpr</c>
	/// labeled alternative in <see cref="LangParser.factor"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFactorExpr([NotNull] LangParser.FactorExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>factorExpr</c>
	/// labeled alternative in <see cref="LangParser.factor"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFactorExpr([NotNull] LangParser.FactorExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>factorVar</c>
	/// labeled alternative in <see cref="LangParser.factor"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFactorVar([NotNull] LangParser.FactorVarContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>factorVar</c>
	/// labeled alternative in <see cref="LangParser.factor"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFactorVar([NotNull] LangParser.FactorVarContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>factorNum</c>
	/// labeled alternative in <see cref="LangParser.factor"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFactorNum([NotNull] LangParser.FactorNumContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>factorNum</c>
	/// labeled alternative in <see cref="LangParser.factor"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFactorNum([NotNull] LangParser.FactorNumContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}
} // namespace Grammar
