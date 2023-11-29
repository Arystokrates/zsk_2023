<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use Illuminate\Support\Facades\DB;
use Illuminate\Support\Facades\Hash;

class DBController extends Controller
{
    public function ShowTableUser(){
        return DB::table('users')

        ->insert([
            'name' => 'Krystyna',
            'email' => 'krystyna@o2.pl',
            'password' => Hash::make("Krystykna123")
        ]);
    }
}
