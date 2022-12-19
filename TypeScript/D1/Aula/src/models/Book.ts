export default class Book {
  private _id: string;
  private _title: string;
  private _salesPrice: number;
  private _cost: number;

  constructor(id: string, t: string, salesPrice: number, cost: number) {
    this._id = id;
    this._title = t;
    this._salesPrice = salesPrice;
    this._cost = cost;
  }

  get id(): string {
    return this._id;
  }
}

const book1 = new Book('2021000001', 'Frankenstein', 40, 32);

const book2 = new Book('2021000002', 'Dune Nuken Kuken', 50, 38);

console.log('Dados do book1: ', book1);
console.log('Dados do book2: ', book2);

console.log('Dados do book1: ', book1.id);
console.log('Dados do book2: ', book2.id);
