var rightExpression = '(((2*3) - 6)*(13*2))';
var wrongExpression = '(((2*3) - 6)*(13*2)';

function isExpressionRight(expression) {
	var leftBrackets = 0;
	var rightBrackets = 0;

	for(var index = 0; index < expression.length; index++) {
		if (expression[index] == '(') {
			leftBrackets++;
		} else if (expression[index] == ')') {
			rightBrackets++;
		}
	}

	if (leftBrackets == rightBrackets) {
		return true;
	}

	return false;
}

var isRightExpression = isExpressionRight(rightExpression);
console.log('Is first expression right: ' + isRightExpression);
var isRightSecondExpression = isExpressionRight(wrongExpression);
console.log('Is first expression right: ' + isRightSecondExpression);

