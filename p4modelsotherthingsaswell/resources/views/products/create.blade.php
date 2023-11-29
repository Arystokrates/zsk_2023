<h3>Dodawanie produktu</h3>
<div>
    <form action="{{route(product.store)}}" method="post">
        @csrf
        <div>
            <label for="name">Nazwa produktu: </label>
            <input type="text" id="name" name="name" value="{{ old('name') }}">
            @error
            <div> {{ $message }}</div>
            @enderror
        </div>
        <div>
            <label for="name">Cena produktu: </label>
            <input type="text" id="price" name="price" value="{{ old('price') }}">
            @error
            <div> {{ $message }}</div>
            @enderror
        </div>
        <div>
            <label for="name">Opis produktu: </label>
            <input type="text" id="description" name="description" value="{{ old('description') }}">
            @error
            <div> {{ $message }}</div>
            @enderror
        </div>
        <button type="submit">Dodaj produkt</button>
    </form>
</div>
