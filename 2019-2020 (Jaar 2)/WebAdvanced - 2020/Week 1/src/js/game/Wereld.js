export default class Wereld {

    constructor(location) {
        this._location = location;
    }

    set X(x) {
        this._location.x = x;
    }

    set Y(y) {
        this._location.y = y;
    }

    getX() {
        return this._location.x;
    }

    getY() {
        return this._location.y;
    }

}