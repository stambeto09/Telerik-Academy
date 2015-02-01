function Solve1(params) {
    var length = parseInt(params[0]);
    var param = params.slice(1, length + 1);

    for (var index = 0; index < param.length; index++) {
        param[index] = parseInt(param[index]);
    }

    var result = -32786;
    var sum = 0;
    var tempStart = 0;

    var startIndex = 0;
    var endIndex = 0;

    for (var index = 0; index < param.length; index++) {

        sum += param[index];
        if (sum > result) {

            result = sum;
            startIndex = tempStart;
            endIndex = index;
        }
        if (sum < 0) {
            sum = 0;
            tempStart = index + 1;
        }
    }

    return result;
}

function Main() {

    var args = ['3 4', '1 3',
    'lrrd',
     'dlll',
     'rddd'];

    console.log(Solve(args));
}