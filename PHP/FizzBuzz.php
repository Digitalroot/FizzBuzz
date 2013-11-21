<?php

  /* By: Digitalroot */

  for ($i = 1; $i <= 100; $i++)
  {
    echo output($i) . "\n";
  }
  
  
  function output($i)
  {
    if ($i % 15 == 0)
    {
      return "FizzBuzz";
    }
    
    if ($i % 3 == 0)
    {
      return "Fizz";
    }
    
    if ($i % 5 == 0)
    {
      return "Buzz";
    }
    return $i;
  }

?>

