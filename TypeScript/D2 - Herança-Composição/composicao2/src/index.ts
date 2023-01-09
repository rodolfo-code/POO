interface Logger {
  log: (param: string) => void;
}

class ConsoleLogger implements Logger {
  log(param: string): void {
    console.log(param);
  }
}

class ConsoleLogger2 implements Logger {
  log(param: string): void {
    console.log("Logger2: " + param);
  }
}

interface Database {
  logger: Logger;
  save: (key: string, value: string) => void;
}

class ExampleDatabase implements Database {
  public logger: Logger = new ConsoleLogger();

  constructor(logger: Logger) {}

  save(key: string, value: string): void {
    this.logger.log(`Salvando o valor ${value} na chave ${key}`);
  }
}

const logger1 = new ConsoleLogger();
const logger2 = new ConsoleLogger2();

const database = new ExampleDatabase(logger1);
const database2 = new ExampleDatabase(logger2);

database.save("rodolfo", "rico");
database2.save("rodolfo vinicius", "rico");
