import Line from '../../../src/js/drawing/Line.js';
import Point from '../../../src/js/drawing/Point.js';

describe('constructor',
    () => {
        it('Should generate a line oboject',
            () => {
                let point1 = new Point(1, 1);
                let point2 = new Point(2, 2);
                let line = new Line(point1, point2);
                expect(line).toBeInstanceOf(Line)
            }
        );
        it('should throw error when first argument is not an instance of Line',
            () => {
                expect(() => {
                    new Line("a", new Point(1, 1));
                }).toThrow(Error)
            });
        it('Should throw error when second argument is not an instance of Line',
            () => {
                expect(() => {
                    new Point(new Point(1, 1), "a");
                }).toThrow(Error)
            })
    }
);

test('getPoint1 & 2 to return the correct value',
    () => {
        let point1 = new Point(1, 1);
        let point2 = new Point(2, 2);
        let line = new Line(point1, point2);
        let point1Returned = line.point1;
        let point2Returned = line.point2;

        expect(point1Returned).toBe(point1);
        expect(point2Returned).toBe(point2);
    });

test('Line toString should be properly returned',
    () => {
        let point1 = new Point(1, 1);
        let point2 = new Point(2, 2);
        let line = new Line(point1, point2);

        expect(line.toString()).toBe("(1,1), (2,2)");
    });