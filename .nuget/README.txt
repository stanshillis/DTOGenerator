
DTO.tt creates DTO type classes out of simple T4 templates.

As a sample create .tt file anywhere in your project, for exmaple BasicDTO.tt
Put the following contents in that file and save it.
You will find generated code inside created BasicDTO.cs file.

~~~~~~~~~~~~~~~~~~~~~~~~~~~~ BasicDTO.tt Contents ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

int Age

string Name

<#@ include file="$(ProjectDir)DTO.tt" #>

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~