grammar Lang;

prog: line+;

line:
	stmt EOL
	| ifst
	//| whilest | forst
	| EOL
    ;

stmt: atrib | input | output;

input: READ VAR;

output: WRITE VAR | WRITE STR | WRITE expr;

ifst:
	IF '(' cond ')' THEN block
	| IF '(' cond ')' THEN block ELSE block;

block: '{' line+ '}';

cond: expr | expr relop expr | cond AND cond | cond OR cond;

relop: RELOP_EQ
	 | RELOP_NE
     | RELOP_LT
     | RELOP_LE
     | RELOP_GT
     | RELOP_GE;
 
atrib: VAR '=' expr;

expr: term '+' expr 
    | term '-' expr 
    | term;

term: factor '*' term
    | factor '/' term
    | factor;

factor: '(' expr ')'
      | VAR
      | NUM
      ;

OE: '(';
CE: ')';
OB: '{';
CB: '}';
EQ: '=';
SUM: '+';
SUB: '-';
MUL: '*';
DIV: '/';
AND: '&&';
OR: '||';
RELOP_EQ: '==';
RELOP_NE: '!=';
RELOP_LT: '<';
RELOP_LE: '<=';
RELOP_GT: '>';
RELOP_GE: '>=';
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