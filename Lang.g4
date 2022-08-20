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
    WRITE VAR           # outputWriteVar
    | WRITE STR         # outputWriteStr
    | WRITE expr        # outputWriteExpr
    ;

ifst:
	  IF '(' cond ')' THEN block                  # ifstIf
	| IF '(' cond ')' THEN b1=block ELSE b2=block # ifstIfElse
    ;
 
block:
     '{' line+ '}'                # blockLine
    ;

cond: 
      expr                        # condExpr
    | e1=expr RELOP=(EQ|NE|LT|GT|LE|GE) e2=expr       # condRelop
    | c1=cond AND c2=cond         # condAnd
    | c1=cond OR c2=cond          # condOr
    | NOT cond                    # condNot
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
AT: '=';
PLUS: '+';
MINUS: '-';
MULT: '*';
DIV: '/';
AND: '&&';
OR: '||';
NOT: '!';
EQ : '==';
LT : '<';
GT : '>';
LE : '<=';
GE : '>=';
NE : '!=';
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