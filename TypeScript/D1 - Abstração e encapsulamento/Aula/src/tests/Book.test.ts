import { expect } from 'chai';
import Book from '../models/Book';

describe('Testes do Book', () => {
  describe('Ao instanciar um novo Book', () => {
    const model = new Book('1', 'TDD', 65, 35);
    it('conseguimos instanciar com sucesso', () => {
      expect(model).to.be.instanceOf(Book);
    });
    it('conseguimos verificar suas propriedades', () => {
      expect(model).to.haveOwnProperty('id');
      expect(model).to.haveOwnProperty('title');
      expect(model).to.haveOwnProperty('salePrice');
      expect(model).to.haveOwnProperty('cost');
    });
  });
});
