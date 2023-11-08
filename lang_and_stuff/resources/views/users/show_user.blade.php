<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>show_user</title>
</head>
<body>
    <h3>Dane użytkownika</h3>

    {{print_r($user)}}
    Imię i nazwsko: {{ $user['firstName'] }}  {{ $user['lastName']}} <br>
    Miasto: {{$user['city']}} <br>
    Hobby: 
    {{--{{print_r($user['hobby'])}} <br>--}}
    {{--Hobby 1: {{$user['hobby'][0]}} --}}

    <ul>
        @foreach($user['hobby'] as $e)
            <li>{{$e}}</li>
        @endforeach
    </ul>

</body>
</html>