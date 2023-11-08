<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;

class UserFormController extends Controller
{
    public function showUser(Request $req){
       #return $req -> input(); {"firstName":"Adam","lastName":"Susz"}
       #return $req -> input("firstName");  Adam
       #return $req -> path(); UserFormController
       #return $req -> url();  http://127.0.0.1:8000/UserFormController
       #return $req -> method();  GET
       #return $req -> all(); {"firstName":"Adam","lastName":"Susz"}

    $req ->validate([
        'firstName' => 'required | min:3 | max:10',
        'lastName' => 'required | min:3 | max:20',
        'mail'=> 'required | email',
    ],
    [
        'firstName.required' => 'Pole :attribute jest wymagane',
        'firstName.min' => 'Pole imię musi mieć minimum :min znaki',
        'firstName.max' => 'Pole imię musi mieć maksimum :max znaków',

        'lastName.required' => 'Pole nazwisko jest wymagane',
        'lastName.min' => 'Pole nazwisko musi mieć minimum 3 znaki',
        'lastName.max' => 'Pole nazwisko musi mieć maksimum 20 znaków',

        'mail.required' => 'Pole :attribute jest wymagane',
        'mail.email' => 'Pole :attribute musi być typu email',

    ]
);


       $dataUser = [
        "firstName" => $req->input("firstName"),
        "lastName"=> $req->input("lastName"),
        "mail" => $req->input("mail"),
       ];

       return view("user",["user" => $dataUser]);

    }
}
