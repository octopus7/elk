mutate { add_field => { "[@metadata][ts]" => "%{StartDate} %{StartTime}" } }
date { match => [ "[@metadata][ts]", "dd.MM.YYYY HH:mm:ss" ] }


https://discuss.elastic.co/t/how-to-merge-separate-date-and-time-to-timestamp/132545
