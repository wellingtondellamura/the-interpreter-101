grammar Lang;

prog: line+             # progLine
    ;

line:
	  stmt EOL          # lineStmt
	| ifst              # lineIf
	//| whilest         # lineWhile
    //| forst           # lineFor
	| EOL              # lineEOL
    ;

stmt: 
      atrib             # stmtAtrib
    | input             # stmtInput
    | output            # stmtOutput
    ;

input: 
    READ VAR            # inputRead
    ;    

output: 
    WRITE VAR           # outputWrite
    | WRITE STR         # outputWriteStr
    | WRITE expr        # outputWriteExpr
    ;

ifst:
	  IF '(' cond ')' THEN block            # ifstIf
	| IF '(' cond ')' THEN block ELSE block # ifstIfElse
    ;
 
block:
     '{' line+ '}'       # blockLine
    ;

cond: 
      expr                  # condExpr
    | expr RELOP expr       # condRelop
    | cond AND cond         # condAnd
    | cond OR cond          # condOr
    ;

atrib: 
     VAR '=' expr            # atribVar
    ;

expr: 
      term '+' expr         # exprPlus
    | term '-' expr         # exprMinus
    | term                  # exprTerm
    ;

term: 
      factor '*' term       # termMult
    | factor '/' term       # termDiv
    | factor                # termFactor
    ;           

factor: 
     '(' expr ')'           # factorExpr
    | VAR                   # factorVar
    | NUM                   # factorNum
    ;

// Lexical rules
OE: '(';
CE: ')';
OB: '{';
CB: '}';
EQ: '=';
PLUS: '+';
MINUS: '-';
MULT: '*';
DIV: '/';
AND: '&&';
OR: '||';
RELOP: '=='|'!='|'<'|'<='|'>'|'>=';
BOOL_TRUE: 'true';
BOL_FALSE: 'false';
IF: [iI][fF];
THEN: [tT][hH][eE][nN];
ELSE: [eE][lL][sS][eE];
WRITE: [wW][rR][iI][tT][eE];
READ: [rR][eE][aA][dD];
STR: '"' ~["]* '"';
EOL: ';';
NUM: [0-9]+ (.([0-9]+))?;
VAR: [a-zA-Z]+;
COMMENT: '//' ~[\r\n]* -> skip;
WS: [ \t\n\r]+ -> skip;