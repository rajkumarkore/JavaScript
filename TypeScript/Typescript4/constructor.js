var Pointe = /** @class */ (function () {
    function Pointe(x, y) {
        this.x = x;
        this.y = y;
    }
    Pointe.prototype.draw = function () {
        console.log('X: ' + this.x + ', Y: ' + this.y);
    };
    return Pointe;
}());
var pointe = new Point();
point.x = 1;
point.y = 2;
point.draw();
