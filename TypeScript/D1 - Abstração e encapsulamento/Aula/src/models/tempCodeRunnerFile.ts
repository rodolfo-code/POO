export default class Book {
  id: string;
  title: string;
  salesPrice: number;
  cost: number;

  constructor(id: string, t: string, salesPrice: number, cost: number) {
    this.id = id;
    this.title = t;
    this.salesPrice = salesPrice;
    this.cost = cost;
  }
}

const book1 = new Book('2021000001', 'Frankenstein', 40, 32);

const book2 = new Book('2021000002', 'Dune Nuken Kuken', 50, 38);

console.log('Dados do book1: ', book1);
console.log('Dados do book2: ', book2);

console.log('Dados do book1: ', book1.id);
console.log('Dados do book2: ', book2.id);
