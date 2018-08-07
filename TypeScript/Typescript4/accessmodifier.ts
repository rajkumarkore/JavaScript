class Pointee{
   private  x: number;
   private y: number;

    constructor(x?: number, y?: number){
        this.x = x;
        this.y = y;

    }

     public  draw() {
        console.log('X: ' + this.x + ', Y: ' +this.y);
    }
}

let pointee = new Point();
point.x = 3;
point.draw();