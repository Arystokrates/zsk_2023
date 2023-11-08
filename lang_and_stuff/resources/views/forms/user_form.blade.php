<!DOCTYPE html>
<html lang="pl">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Dane użytkownika</title>
</head>
<style>
    body{
        background-color: #26303E;
        color: white;
        padding: 2rem;
    }
</style>
<body>
    <h3>Dane użytkownika</h3>

    @if($errors -> any())
    <ul>
        @foreach($errors->all() as $error)
            <li>{{$error}}</li>
        @endforeach
    </ul>
    @endif


    <form action="UserFormController" method="get">
        <input type="text" name="firstName" placeholder="Podaj imię" autofocus value="{{old('firstName')}}"> 
        @error('firstName')
            {{$message}}
        @enderror
        <br> <br>
        <input type="text" name="lastName" placeholder="Podaj nazwisko" value="{{old('lastName')}}">
        @error('lastName')
            {{$message}}
        @enderror
        <br> <br>
        <input type="email" name="mail" placeholder="Podaj poczte elektroniczną" value="{{old('mail')}}">
        @error('mail')
            {{$message}}
        @enderror
        <br> <br>
        <input type="submit" value="Zatwierdź dane">
    </form>
</body>
</html>