interface Person {
  name: string;
  info: string;
}

class Student implements Person {
  constructor(public name: string, public school: string) {}

  get info() {
    return `${this.name} estuda no colégio ${this.school}`;
  }
}

class Professor implements Person {
  constructor(
    public name: string,
    public school: string,
    public subject: string
  ) {}

  get info() {
    return `${this.name} leciona ${this.subject} no colégio ${this.school}`;
  }
}

function printInfo(person: Person) {
  console.log(person.info);
}

const student: Person = new Student("Rodolfo", "SESI");
const professor: Person = new Professor(
  "Oliveira",
  "MIT",
  "Arquitetura de software"
);

printInfo(student);
printInfo(professor);
