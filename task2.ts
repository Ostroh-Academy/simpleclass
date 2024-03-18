class Point3D {
    private x: number;
    private y: number;
    private z: number;

    constructor(x: number, y: number, z: number) {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public areAllCoordinatesInteger(): boolean {
        return Number.isInteger(this.x) && Number.isInteger(this.y) && Number.isInteger(this.z);
    }

    public areAllCoordinatesInFirstOctant(): boolean {
        return this.x > 0 && this.y > 0 && this.z > 0;
    }

    // Метод для введення координат
    public static inputPoint(): Point3D {
        let x: number = parseFloat(prompt("Enter x coordinate:") || '0');
        let y: number = parseFloat(prompt("Enter y coordinate:") || '0');
        let z: number = parseFloat(prompt("Enter z coordinate:") || '0');

        return new Point3D(x, y, z);
    }
}

// Точка введення та виведення результатів
let point: Point3D = Point3D.inputPoint();
console.log(`Are all coordinates integer: ${point.areAllCoordinatesInteger()}`);
console.log(`Are all coordinates in the first octant: ${point.areAllCoordinatesInFirstOctant()}`);
  