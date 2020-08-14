'use strict';

class Service {

    constructor() {

        this.map = new Map();
    }

    add(obj) {

        if(obj == null || obj == undefined) {

            return null;
        }

        else{

            let id = Math.random().toString(16).substr(2, 10);

            this.map.set(id, obj);

            return id;
        }   
    }

    getById(id) {

        if(id == null || id == undefined){

            return null;
        }

        else{

            return this.map.has(id) ? this.map.get(id) : null;
        }
    }

    getAll() {

        return this.map.values();
    }

    deleteById(id) {

        if(id == null || id == undefined){

            return null;
        }

        else{

            if(this.map.has(id)) {

                let obj = this.map.get(id);
                this.map.delete(id);
                return obj;
            }

            else{

                return null;
            }
        }
    }

    updateById(id, obj) {

        if(id == null || id == undefined || obj == null || obj == undefined){

            return;
        }

        else{

            if(this.map.has(id)) {

                for(let el in obj) {

                    this.map.get(id)[el] = obj[el];
                }
            }

            else{

                this.map.set(id, obj);
            }
        }
    }

    replaceById(id, obj) {

        if(id == null || id == undefined || obj == null || obj == undefined) {

            return;
        }

        else{

            if(this.map.has(id)) {

                this.map.delete(id);
            }

            this.map.set(id, obj);
        }
    }
}

let storage = new Service();

let person1 = storage.add({ 'name': 'Alex', 'age': 22});

let person2 = storage.add({ 'name': 'Max', 'age': 25});

let person3 = storage.add({ 'name': 'Cody', 'age': 27});

console.log(storage.getAll());

console.log(storage.getById(person1));

console.log(storage.deleteById(person2));

console.log(storage.getAll());

console.log(storage.updateById(person3, {'age': 29}));

console.log(storage.getAll());

console.log(storage.replaceById(person1, '01001001'));

console.log(storage.getAll());