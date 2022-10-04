graph = {
    10 : [8, 13],
    8 : [3, 9],
    13 : [15],
    3 : [],
    9 : [],
    15 : []
}


visited = set()


def dfs(node, goal):
    if node in visited: return
    print(node)
    if node == goal:
        print('Found goal!')
        return node

    visited.add(node)
    for neighbor in graph[node]:
        res = dfs(neighbor, goal)
        if res is not None:
            return res
        

res = dfs(node=10, goal=1)
