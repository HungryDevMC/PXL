import Point from "./Point";

class TypeError extends Error {}

export default class Line {

    constructor(point1, point2) {
        if(!(point1 instanceof Point && point2 instanceof Point)) {
            throw new TypeError("Arguement is not an instanceof Point");
        }
        this._point1 = point1;
        this._point2 = point2;
    }

    set point1(value) {
        if(!(value instanceof Point)) {
            throw new TypeError("Arguement is not an instanceof Point");
        }
        this._point1 = value;
    }

    set point2(value) {
        if(!(value instanceof Point)) {
            throw new TypeError("Arguement is not an instanceof Point");
        }
        this._point2 = value;
    }

    get point1() {
        return this._point1;
    }

    get point2() {
        return this._point2;
    }

    toString() {
        return `${this.point1.toString()}, ${this.point2.toString()}`;
    }

}