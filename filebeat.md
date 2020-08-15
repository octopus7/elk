https://www.elastic.co/kr/downloads/beats/filebeat

윈도우용 설치

zip파일 64비트 윈도우용으로 다운

폴더 이름변경  filebeat-<version>-windows -> Filebeat

C:\Program Files 로 이동

파워쉘 관리자권한으로 실행

cd 'C:\Program Files\Filebeat'
.\install-service-filebeat.ps1

권한필요시
Get-Help Set-ExecutionPolicy
Set-ExecutionPolicy RemoteSigned



