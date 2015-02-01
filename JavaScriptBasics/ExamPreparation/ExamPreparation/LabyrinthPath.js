function Solve(params) {

    var firstParam = params[0].split(' ');
    var row = parseInt(firstParam[0]);
    var col = parseInt(firstParam[1]);

    var secondParam = params[1].split(' ');
    var currentRow = parseInt(secondParam[0]);
    var currentCol = parseInt(secondParam[1]);

    var matrix = [];

    for (var index = 0; index < col - 1; index++) {
        matrix[index] = params[index + 2];
    }
    var sum = 0;
    var cellNumber = 1;
    var isLost = false;
    var isEscaped = false;

    var visitedRows = [-1];
    var visitedCols = [-1];

    while ((currentRow >= 0 && currentRow < row) && (currentCol >= 0 && currentCol < col)) {


        cellNumber++;
        sum = sum + currentRow * 4 + currentCol + 1;

        if (matrix[currentRow][currentCol] == 'd') {
            currentRow++;
            if (currentCol == col - 1) {
                isEscaped = true;
            }

        } else if (matrix[currentRow][currentCol] == 'u') {
            currentRow--;
            if (currentCol == 0) {
                isEscaped = true;
            }

        } else if (matrix[currentRow][currentCol] == 'l') {
            currentCol--;
            if (currentRow == 0) {
                isEscaped = true;
            }

        } else if (matrix[currentRow][currentCol] == 'r') {
            currentCol++;
            if (currentRow == row - 1) {
                isEscaped = true;
            }

        }

        for (var index = 0; index < visitedRows.length; index++) {

            if (visitedRows[index] == currentRow && visitedCols[index] == currentCol) {
                isLost = true;
                break;
            }
            if (index == visitedRows.length - 1) {
                visitedCols.push(currentCol);
                visitedRows.push(currentRow);
                break;
            }
        }

        if (isEscaped || isLost) {
            sum = sum + currentRow * 4 + currentCol + 1;
            break;
        }

    }

    if (isEscaped) {
        return 'out' + sum;
    } else if (isLost) {
        return 'lost' + cellNumber;
    }
}