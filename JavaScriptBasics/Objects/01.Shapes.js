function Point (xCord, yCord){
	this.xCord = xCord;
	this.yCord = yCord;
	this.clone = function () {
                return new Point(this.x, this.y);
            }
    this.getDistance = function (point) {
    	return Math.sqrt((this.xCord - point.xCord) * (this.xCord - point*xCord) 
    		+ (this.yCord - point.yCord)*(this.yCord - point.yCord));
    }
    this.clone = function () {
    	return new Point(this.xCord, this.yCord);
    }
}


var point = new Point(10, 12);
console.log(point.xCord);
console.log(point.yCord);

function Line (firstPoint, secondPoint){
	this.start = firstPoint.clone();
	this.end = secondPoint.clone();
	this.getLength = function () {
		return this.start.getDistance(this.end);
	};
}

function checkForTriangle(firstLine, secondLine, thirdLine) {
	var firstLine = firstLine.getLength();
	var secondLine = secondLine.getLength();
	var thirdLine = thirdLine.getLength();

	return firstLine + secondLine > thirdLine && firstLine + thirdLine > secondLine && secondLine + thirdLine > firstLine;
}