import Wereld from "./Wereld";

export default class Hero extends Wereld {

    constructor(location) {
        super(location);
    }

    moveDown () {
        this.Y = this.getX() - 1;
    }

    moveUp () {
        this.Y = this.getY() + 1
    }

    moveLeft () {
        this.X = this.getX() - 1;
    }

    moveRight () {
        this.X = this.getX() + 1;
    }

}