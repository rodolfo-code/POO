class Superclass {
  public isSuper: boolean;

  constructor(isSuper: boolean) {
    this.isSuper = isSuper;
  }

  sayHello() {
    console.log("Ola mundo");
  }
}

export default Superclass;
