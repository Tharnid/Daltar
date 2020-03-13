# DotNet Core

dotnet tool install --global dotnet-ef --version 3.0.0

Microsoft.EntityFrameworkCore.Design

CTRL + P search in vscode

# Angular

ng new BandMatch-SPA

ng serve

Go to the definition of variables/functions when press f12 within html.

Switch .ts|.html|.css|.spec.ts quickly

alt+o(Windows) shift+alt+o(macOS)

if on .ts|.css|.spec.ts: go to html
if on .html: go to previous

alt+i(Windows) shift+alt+i(macOS)

if on .ts|.html|.spec.ts: go to css
if on .css: go to previous

alt+u(Windows) shift+alt+u(macOS)

if on .css|.html|.spec.ts: go to ts
if on ts: go to previous

alt+p(Windows) shift+alt+p(macOS)

if on .ts|.css|.html: go to spec.ts
if on .spec.ts: go to previous

[Required]
[EmailAddress]
[StringLength]

## To Remove a Table from a Database

1. Manualy delete table
2. Remove records from _EFMigrationsHistory
3. Run update database 

Repository Pattern - mediates between the data source layer and the business layer of application

Interface exposes methods that the controllers can utilize

DTO - data transer object...map domain models into simpler objects

git rm appsettings.json --cached

dotnet user-secrets init

<pre>
  Form Valid: {{loginForm.valid}}
  Form Touched: {{loginForm.touched}}
  Form Dirty: {{loginForm.dirty}}
  Form Values: {{loginForm.value | json}}
  Username Valid: {{username.valid}}
  Username Touched: {{username.touched}}
  Username Dirty: {{username.dirty}}
  Username Value: {{username.value}}
  Password Valid: {{password.valid}}
  Password Touched: {{password.touched}}
  Password Dirty: {{password.dirty}}
  Password Value: {{password.value}}
</pre>

The job a component is to provide the data for the template!!!....gets and provides data

alt + o (to switch between component html and ts files)

## Component Communcation

parent to child
child to parent

## decodedToken for displaying username...only displayed on login

set token in auth service

## Getting out of trouble with migrations

referentialAction = cascade...user deleted everything associated is deleted 