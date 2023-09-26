<?php

use App\Http\Controllers\ProfileController;
use Illuminate\Support\Facades\Route;

/*
|--------------------------------------------------------------------------
| Web Routes
|--------------------------------------------------------------------------
|
| Here is where you can register web routes for your application. These
| routes are loaded by the RouteServiceProvider and all of them will
| be assigned to the "web" middleware group. Make something great!
|
*/

Route::get('/', function () {
    return view('welcome');
});

Route::get('/dashboard', function () {
    return view('dashboard');
})->middleware(['auth', 'verified'])->name('dashboard');

Route::middleware('auth')->group(function () {
    Route::get('/profile', [ProfileController::class, 'edit'])->name('profile.edit');
    Route::patch('/profile', [ProfileController::class, 'update'])->name('profile.update');
    Route::delete('/profile', [ProfileController::class, 'destroy'])->name('profile.destroy');
});

// ------

Route::get('/city_old', function(){
    return "Miasto";
});

Route::get('/city', function(){
    return view('city');
});

Route::redirect(uri:'/', destination:'/city_old');

Route::redirect(uri:'/', destination:'/city', status:301);

Route::get('/status', function(){
    return response()->json([
        'error' => false,
        'code' => 203,
        'message' => 'everything works just fine!'
    ], 500)->status();
    
});

Route::get('city2', function(){
    // return ["name" => "Janusz", "city" => "Poznań"];
    return view('city', ["name" => "Janusz", "city" => "Poznań"]);
});

Route::get('page/{x}', function($x){
    return $x;
});

Route::get('pages/{x}', function($x){
    $info = [
        "about" => "Informacje o stronie",
        "contact" => "contact@o2.pl",
        "home" => "Strona domowa"
    ];
    return $info[$x];
});

// ------

require __DIR__.'/auth.php';