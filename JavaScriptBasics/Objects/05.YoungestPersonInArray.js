function Person (firstName, secondName, age) {
	this.firstName = firstName;
	this.secondName = secondName;
	this.age = age;
}
var persons = [
{firstName: 'Gosho', secondName: 'Petrov', age: 15},
{firstName: 'Ivo', secondName: 'Georgiev', age: 32},
{firstName: 'Petyo', secondName: 'Ruzhin', age: 13}];

var minAgePerson = new Person('Pesho', 'Testa', Math.pow(2,32));
console.log(minAgePerson.age);

for(var index = 0; index < persons.length; index++){
	if (persons[index].age < minAgePerson.age) {
		minAgePerson = persons[index];
	}
}

//Printing all the properties of the youngest person
for(var property in minAgePerson){
	console.log(minAgePerson[property]);
}