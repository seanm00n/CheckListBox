# .gitignore 파일에서 무시할 파일/디렉토리 목록을 가져옵니다.
$ignorePatterns = Get-Content .gitignore | Where-Object { $_ -match '^[^#]' }

# 무시할 파일/디렉토리를 삭제합니다.
foreach ($pattern in $ignorePatterns) {
    Remove-Item -Recurse -Force -Path $pattern
}

# 변경사항을 Git에 커밋합니다.
git commit -m "gitignore에 지정된 파일을 삭제함"