<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;

class ArrayController extends Controller
{
    public function show_array(){
        $user = [
            "firstName" => 'Janusz',
            "lastName" => "Nowak",
            "city" => "Poznań",
            "hobby" => ["żużel", "siatkówka", "skoki narciarskie"]
        ];
        return view('users.show_user' , ['user'=> $user]);
    }
}
