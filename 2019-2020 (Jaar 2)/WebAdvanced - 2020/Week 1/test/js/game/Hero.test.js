import Hero from '../../../src/js/game/Hero';
import Location from '../../../src/js/game/Location';


test('moveLeft should change the location value properly',
    () => {
        let hero = new Hero(new Location(0, 0));
        hero.moveLeft();
        let x = hero.getX();
        expect(x).toBe(-1);
    });

test('moveRight should change the location value properly',
    () => {
        let hero = new Hero(new Location(0, 0));
        hero.moveRight();
        let x = hero.getX();
        expect(x).toBe(1);
    });