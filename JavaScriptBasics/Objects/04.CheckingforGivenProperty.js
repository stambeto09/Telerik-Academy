function Dog (breed, color){
	this.color = color;
	this.breed = breed;
}
var dog = new Dog('street','brown');

function isExistProperty (object, propertyName) {
	var result = false;
	for(var property in object){
		if(property == propertyName){
			result = true;
			break;
		}
	}
	return result;
}

var boolResultForDogProp = isExistProperty(dog, 'dog');
console.log('Is dog property exists: ' + boolResultForDogProp);

var boolResultForColorProp = isExistProperty(dog, 'color');
console.log('Is color property exists: ' + boolResultForColorProp);
