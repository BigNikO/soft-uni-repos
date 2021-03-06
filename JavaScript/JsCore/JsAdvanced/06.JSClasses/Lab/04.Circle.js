class Circle {
  constructor(radius) {
    this.radius = +radius;
  }

  get diameter() {
    return this.radius * 2;
  }

  set diameter(diameter) {
    this.radius = diameter / 2;
  }

  get area() {
    return this.radius ** 2 * Math.PI;
  }
}

const c = new Circle(2);

console.log(c.radius);
console.log(c.diameter);
console.log(c.area);
