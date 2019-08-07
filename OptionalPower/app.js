const io = require('console-read-write')

async function optionalPower(a,b) {
    console.log('Do you agree? Y/N');
    var input = await io.read();
    console.log(input);
    if (input==='Y'|| input==='y') {
        console.log(Math.pow(a,b));
    }else if (input==='N'||input==='n') {
        console.log(Math.pow(b,a));
    }else{
        console.log('Wrong choice! Input Y or N.');
    }
}

( async () => {
    await optionalPower(2,5);
})();