interface User {
  id?: number;
  name: string;
  age: number;
}

class UserModel {
  private database: User[] = [];
  private lastId = 0;

  create(user: User) {
    const newUser: User = { ...user, id: this.lastId++ };
    this.database.push(newUser);

    return newUser;
  }

  getAll(): User[] {
    return [...this.database];
  }
}

class UserService {
  constructor(private userModel: UserModel) {}

  create(user: User): User {
    if (user.age > 200) {
      throw new Error("Idade avançada");
    }

    return this.userModel.create(user);
  }

  getAll() {
    return this.userModel.getAll();
  }
}

const userModel = new UserModel();
const userService = new UserService(userModel);

const capi = userService.create({
  name: "Capi",
  age: 12,
});

const andre = userService.create({
  name: "Andre",
  age: 100,
});

console.log(userService.getAll());
