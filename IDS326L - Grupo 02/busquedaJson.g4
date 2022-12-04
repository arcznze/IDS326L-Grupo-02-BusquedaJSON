grammar busquedaJson;

program : input;

input: TEXTO (PUNTO TEXTO)* ('['NUMERO']')*;

TEXTO :[A-Za-z_]+;
NUMERO:[0-9]+;

PUNTO : '.';

WS: [ \t\n\r] + -> skip;