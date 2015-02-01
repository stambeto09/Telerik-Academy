 function groupPeople(array, property) {
            switch (property) {
                case "firstName": break;
                case "lastName": break;
                case "age":
                    {
                        var sorted = [];
                        for (var i = 0; i < array.length; i++) {
                            if (sorted[array[i].age] == undefined) {
                                sorted[array[i].age] = [];
                                sorted[array[i].age].push(array[i]);
                            }
                            else {
                                sorted[array[i].age].push(array[i]);
                            }
                        }
                        return sorted;
                    } 
                    break;
                	default: throw new Error("Error message"); break;
    			}
}
