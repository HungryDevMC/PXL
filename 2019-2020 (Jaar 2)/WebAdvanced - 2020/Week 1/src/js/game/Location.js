"use strict";

export default class Location{
	constructor(x,y){
  		if (isNaN(x) || isNaN(y)) {
    		throw new Error("Parameter is not a number!");
  		}
		this.x=x;
		this.y=y;
	}

	get getX(){
		return this.x;
	}
	get getY(){
		return this.y;
	}

    toString() {
        return `(${this.x},${this.y})`;
    }
}
