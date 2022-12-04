grammar busquedaJson;

program : input+ EOF;

input: property+ PUNTO? | array+ PUNTO?;

property: TEXTO;
array: '['primernumero? DOBLEPUNTO segundonumero']';
primernumero: NUMERO;
segundonumero: NUMERO;

TEXTO: [A-Za-z_]+;
NUMERO: [0-9]+;

DOBLEPUNTO : ':';
PUNTO : '.';

WS: [ \t\n\r] + -> skip;