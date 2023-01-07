// import Superclass from "./superClass";

class Superclass {
  public isSuper: boolean;

  constructor(isSuper: boolean) {
    this.isSuper = isSuper;
  }

  sayHello() {
    console.log("Ola mundo");
  }
}

class SubClass extends Superclass {
  constructor(protected name: string, superClassArg: boolean) {
    super(superClassArg);
  }
}

const newObj: Superclass = new Superclass(true);
const outroObj: SubClass = new SubClass("Rodolfo", false);

function myFunc(superObj: Superclass) {
  return superObj.isSuper ? console.log("Super") : console.log("Sub");
}

myFunc(newObj);

myFunc(outroObj);
