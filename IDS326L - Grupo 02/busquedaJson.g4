grammar busquedaJson;

program : (json)+ EOF ;

json: valor;

objeto: '{' datos (',' datos)* '}'
   | '{' '}';

datos: STRING ':' valor;

array: '[' valor (',' valor)* ']'
    | '[' ']';

valor: STRING
   | objeto
   | array;

STRING: '"' (TEXTO | MAGIAMANITO)* '"';

TEXTO :'"'[A-Za-z_]+ '"';

fragment MAGIAMANITO: ~ ["\\\u0000-\u001F] ;

WS: [ \t\n\r] + -> skip;