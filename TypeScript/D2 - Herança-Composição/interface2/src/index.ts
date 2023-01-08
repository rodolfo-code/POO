interface MyInterface {
  myNumber: number;
  myFunc: (myParam: number) => string;
}

class MyClass implements MyInterface {
  constructor(public myNumber: number) {}

  myFunc(myParam: number) {
    const result: number = myParam + this.myNumber;
    return `O resultado final é: ${result}`;
  }
}

const myResult: MyClass = new MyClass(20);

function result(arg: MyClass) {
  console.log(arg.myFunc(30));
}

result(myResult);
