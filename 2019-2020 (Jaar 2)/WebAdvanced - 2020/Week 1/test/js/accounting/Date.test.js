import Date from '../../../src/js/accounting/Date';

test('toString should be returned properly',
    () => {
        let date = Date.make(1, 1, 2000);

        expect(date.toString()).toBe("1/1/2000");
    });

test('toStringMonth should be returned properly',
    () => {
        let date = Date.make(1, 1, 2000);

        expect(date.toStringMonth()).toBe("1/jan/2000");
    });