var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var value = input.replace(/(^\s+)|(\s+$)/g, "").split("_")
process.stdout.write(value[0]);

String.prototype.capitalize = function(){
    return this.charAt(0).toUpperCase() + this.slice(1);
}

for(var i = 1; i < value.length; i++ ){
  process.stdout.write( value[i].capitalize() );
}
