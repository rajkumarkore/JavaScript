class Pointe{
    x: number;
    y: number;

    constructor(x?: number, y?: number){
        this.x = x;
        this.y = y;

    }

    draw() {
        console.log('X: ' + this.x + ', Y: ' +this.y);
    }
}

let pointe = new Point();
point.x = 1;
point.y = 2;

point.draw();