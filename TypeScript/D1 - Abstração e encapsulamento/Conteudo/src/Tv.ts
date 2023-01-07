class Tv {
  private _brand: string;
  private _size: number;
  private _resolution: string;
  private _connections: string[];
  private _connectedTo?: string;

  constructor(
    brand: string,
    size: number,
    resolution: string,
    connections: string[],
    connectedTo: string,
  ) {
    this._brand = brand;
    this._size = size;
    this._resolution = resolution;
    this._connections = connections;
    this._connectedTo = connectedTo;
  }

  turnOn(): void {
    console.log(
      `TV ${this._brand}, ${this._size}", resolution: ${this._resolution} \n\
        available connections: ${this._connections}`,
    );
  }

  get connectedTo(): string | undefined {
    return this._connectedTo;
  }

  set connectedTo(connection: string | undefined) {
    if (!connection || this._connections.includes(connection)) {
      this._connectedTo = connection;
      console.log(this._connectedTo);
    } else {
      console.log('Sorry, connection unavailable!');
    }
  }
}

const tv = new Tv('Lg', 24.8, '4k', ['bluetooth', 'Ethernet'], 'HD');
tv.turnOn();
tv.connectedTo = 'bluetooth';
console.log('Connected to: ', tv.connectedTo);
