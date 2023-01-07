class Vehicle {
  constructor(public brand: string, private automaker: string) {}

  public speed(): string {
    console.log(`O ${this.brand} acelera pra caramba!`);
    return `O  ${this.brand} acelera muito!`;
  }
}

class Car extends Vehicle {
  constructor(brand: string, automaker: string) {
    super(brand, automaker);
  }

  // public speed(): string {
  //   console.log(`O ${this.brand} acelera!`);
  //   return super.speed() + `Acelera o ${this.brand}!`;
  // }
}

const carro = new Car("Corsa", "GM");

const ac = carro.speed();
console.log(ac);

// carro.speed();
