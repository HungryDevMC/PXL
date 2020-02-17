export default class Date {
    constructor(day, month, year) {
        this._day = day;
        this._month = month;
        this._year = year;
    }

    static MONTHS(){
        return ["jan","feb","mar","apr","may","jun","jul","aug","sep","oct","nov","dec"];
    }

    get day() {
        return this._day;
    }

    get month() {
        return this._month;
    }

    get year() {
        return this._year;
    }


    set day(value) {
        this._day = value;
    }

    set month(value) {
        this._month = value;
    }

    set year(value) {
        this._year = value;
    }

    static make (day, month, year) {
        return new Date(day, month, year);
    }

    toString() {
        return `${this.day}/${this.month}/${this.year}`;
    }

    toStringMonth() {
        return `${this.day}/${Date.MONTHS()[this.month - 1]}/${this.year}`
    }

}