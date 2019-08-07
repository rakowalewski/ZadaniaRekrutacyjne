

async function fixage(ages){
    var result = new Array();
    for (const key in ages) {
        if(ages[key]>=18 && ages[key]<=60){
            result.push(ages[key]);
        }
    }
    if (result.length===0) {
        return 'NA';
    }else{
        return result.join(',');
    }
}

(async()=>{
    var result = await fixage([18,3,30,22,11,60]);
    console.log({result});
})();